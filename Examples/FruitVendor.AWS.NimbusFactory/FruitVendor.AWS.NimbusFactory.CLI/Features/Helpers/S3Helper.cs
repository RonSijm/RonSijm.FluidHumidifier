using Humidifier.CloudFront.DistributionTypes;
using Humidifier.S3.BucketTypes;
using RonSijm.FluidHumidifier.Factories.Route53;
using Environment = Humidifier.Lambda.FunctionTypes.Environment;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.Helpers;
public static class S3Helper
{
    public static void WithPublicCloudFrontPolicy(StackFactory stack, string name, BucketFactory environmentVarBucket)
    {
        //var condition = new Dictionary<string, Dictionary<string, object>>
        //{
        //    ["StringLike"] = new()
        //    {
        //        ["AWS:SourceArn"] = $"arn:aws:cloudfront::{Environment.AWSAccountId}:distribution/*"
        //    },
        //};

        stack.WithS3BucketPolicy($"{name}-Policy", x =>
        {
            x.Bucket = environmentVarBucket.FFnREF();
            x.PolicyDocument = new
            {
                Version = "2012-10-17",
                Statement = new[]
                {
                    new
                    {
                        Effect = "Allow",
                        // Principal = new PolicyPrincipal { Service = "cloudfront.amazonaws.com"},
                        Principal = "*",
                        Action = new[] { "s3:GetObject" },
                        Resource = new[] { $"arn:aws:s3:::{name}/*" },
                        //Condition = condition
                    }
                }
            };
        });
    }

    public static void WithPublicCloudFront(StackFactory stack, string bucketName, EnvironmentConfig environment, string subDomainName = null)
    {
        var domain = $"*.fruitvendor.example";

        if (subDomainName != null)
        {
            domain = $"{subDomainName}.fruitvendor.example";
        }

        var aliases = new List<string> { domain };

        var cnames = new List<string>()
        {
            domain
        };

        if (subDomainName == null)
        {
            cnames.Add("fruitvendor.example");
            aliases.Add("fruitvendor.example");
        }

        var distribution = stack.WithCloudFrontDistribution($"{bucketName}-CF", config =>
        {

            config.DistributionConfig = new DistributionConfig()
            {

                Aliases = aliases,
                Origins = new List<Origin>()
                {
                    new()
                    {
                        DomainName = $"{bucketName}.s3.{environment.Region}.amazonaws.com",
                        Id = bucketName,
                        S3OriginConfig = new S3OriginConfig()
                        {
                            OriginAccessIdentity = ""
                        }
                    }
                },
                DefaultCacheBehavior = new DefaultCacheBehavior()
                {
                    TargetOriginId = bucketName,
                    ViewerProtocolPolicy = "redirect-to-https",
                    AllowedMethods = new[] { "GET", "HEAD", "OPTIONS" },
                    CachedMethods = new[] { "GET", "HEAD", "OPTIONS" },
                    CachePolicyId = "658327ea-f89d-4fab-a63d-7e88639e58f6",
                    Compress = true,
                    SmoothStreaming = false,
                },
                PriceClass = "PriceClass_All",
                ViewerCertificate = new ViewerCertificate()
                {
                    AcmCertificateArn = CertificateSelector.GetCertificateArnFromGlobal(environment.EnvironmentName),
                    MinimumProtocolVersion = "TLSv1.2_2021",
                    SslSupportMethod = "sni-only"
                },
                Enabled = true,
            };
        });

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = "fruitvendor.example.";
            record.Type = "CNAME";
            record.Name = domain;
            record.TTL = Fn.Literal(300);
            record.ResourceRecords = new List<Union<string, BaseFunction>>() { FFn.FFnGetAtt(distribution, "DomainName") };
            record.ResourceName = $"{domain}-cname";
        });

        if (subDomainName == null)
        {
            stack.WithRecordSet(record =>
            {
                record.HostedZoneName = "fruitvendor.example.";
                record.Type = "A";
                record.Name = "fruitvendor.example";
                record.ResourceName = $"{domain}-a-record";
            }).WithAliasTarget(alias =>
            {
                alias.DNSName = FFn.FFnGetAtt(distribution, "DomainName");
                alias.HostedZoneId = "Z2FDTNDATAQYW2";
            });
        }
    }

    public static BucketFactory BucketWithPublicAccess(StackFactory stack, string name, bool asWebsite = false)
    {
        var bucket = stack.WithS3Bucket(name).WithPublicAccessBlockConfiguration(acl =>
        {
            acl.BlockPublicAcls = false;
            acl.BlockPublicPolicy = false;
            acl.IgnorePublicAcls = false;
            acl.RestrictPublicBuckets = false;
        });

        bucket.WithOwnershipControls(owner =>
        {
            var rule = new OwnershipControlsRule
            {
                ObjectOwnership = "BucketOwnerEnforced"
            };

            owner.Rules = new[] { rule };
        });

        if (asWebsite)
        {
            bucket.WithWebsiteConfiguration(website =>
            {
                website.IndexDocument = "index.html";
                website.ErrorDocument = "index.html";
            });
        }

        return bucket.T1;
    }
}
