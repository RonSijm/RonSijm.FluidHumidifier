using RonSijm.FluidHumidifier.Factories.Custom;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CircleCIUserStack;

public class CircleCIUserStackComposer : BaseStackComposer<CircleCIUserStackConfig>
{
    public override StackCreateResult Create(CircleCIUserStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("CircleCI User");

        var githubActionsDeployPolicy = stack.WithManagedPolicy("CircleCI-Deploy");

        var deployPolicyDocument = githubActionsDeployPolicy.WithDocument();

        if (config.UseFineTunedPolicy)
        {
            CreateFineTunedPolicy(deployPolicyDocument);
        }
        else
        {
            CreateFullAccessPolicy(deployPolicyDocument);
        }

        var provider = stack.WithOIDCProvider("CircleCIOidcProvider", provider =>
        {
            provider.ClientIdList = new[]
            {
                "sts.amazonaws.com",
                config.CircleCIOrgId
            };
            provider.ThumbprintList = new[] { config.Thumbprint };
            provider.Url = $"https://oidc.circleci.com/org/{config.CircleCIOrgId}";
        });

        var githubActionsRole = stack.WithRole("CircleCIDeploy", role =>
        {
            role.RoleName = "CircleCI-Deploy-Role";
            role.ManagedPolicyArns = new List<dynamic>
            {
                config.OIDCSafetyPolicyArn,
                githubActionsDeployPolicy.FFnREF()
            };
        });

        var assumeRolePolicy = githubActionsRole.WithAssumeRolePolicy();

        var condition = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringLike"] = new() { [$"oidc.circleci.com/org/{config.CircleCIOrgId}:aud"] = config.CircleCIOrgId },
        };

        assumeRolePolicy.WithStatement(action: "sts:AssumeRoleWithWebIdentity", principle: new
        {
            Federated = $"arn:aws:iam::{Environment.AWSAccountId}:oidc-provider/oidc.circleci.com/org/{config.CircleCIOrgId}"
        }, condition: condition);

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult
        };

        return result;
    }

    private void CreateFineTunedPolicy(PolicyDocumentFactory deployPolicyDocument)
    {
        deployPolicyDocument.WithStatement(new List<string>()
            {
                "ecr:*",
                "sts:AssumeRoleWithWebIdentity"
            },
            resource: "*",
            effect: "Allow"
        );

        if (Environment.EnvironmentName != AccountConfigSettings.AssetAccountName)
        {
            deployPolicyDocument.WithStatement(new List<string>()
            {
                "ecs:UpdateService",
                "ecs:DescribeServices"
            }, new List<string>()
            {
                "*"
            }, "Allow");
        }
        else
        {
            deployPolicyDocument.WithStatement(new List<string>()
            {
                "s3:ListBucket",
                "s3:GetObject",
                "s3:PutObject",
                "s3:HeadObject",
            }, new List<string>()
            {
                $"arn:aws:s3:::applestore-{Environment.EnvironmentName}-webapp-precompiledassets",
                $"arn:aws:s3:::applestore-{Environment.EnvironmentName}-webapp-precompiledassets/*",
                $"arn:aws:s3:::applestore-{Environment.EnvironmentName}-webapp-dockercache",
                $"arn:aws:s3:::applestore-{Environment.EnvironmentName}-webapp-dockercache/*"
            }, "Allow");

            deployPolicyDocument.WithStatement(new List<string>()
                {
                    "ecr:GetDownloadUrlForLayer",
                    "ecr:BatchGetImage",
                    "ecr:BatchCheckLayerAvailability",
                    "ecr:PutImage",
                    "ecr:InitiateLayerUpload",
                    "ecr:UploadLayerPart",
                    "ecr:CompleteLayerUpload",
                    "ecr:DescribeRepositories",
                    "ecr:ListImages"
                },
                resource: $"arn:aws:ecr:*:{Environment.AWSAccountId}:repository/*",
                effect: "Allow"
            );

            deployPolicyDocument.WithStatement(new List<string>()
                {
                    "cloudfront:CreateInvalidation",
                },
                resource: $"arn:aws:cloudfront::{Environment.AWSAccountId}:distribution/",
                effect: "Allow"
            );
        }
    }

    private void CreateFullAccessPolicy(PolicyDocumentFactory deployPolicyDocument)
    {
        deployPolicyDocument.WithStatement(new List<string>()
            {
                "ecr:*",
            },
            resource: $"arn:aws:ecr:*:{AccountConfigSettings.AssetAccountId}:repository/*",
            effect: "Allow"
        );

        deployPolicyDocument.WithStatement(new List<string>()
            {
                "ecs:*",
            },
            resource: "*",
            effect: "Allow"
        );
    }
}
