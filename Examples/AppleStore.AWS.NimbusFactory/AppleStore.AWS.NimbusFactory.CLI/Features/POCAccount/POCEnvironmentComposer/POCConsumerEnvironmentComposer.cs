using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECRServiceAccessStack;
////using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.POCAccount.POCEnvironmentComposer;

public class POCConsumerEnvironmentComposer(
    GithubUserStackComposer githubUserStackComposer,
    ERCServiceAccessStackComposer ecrServiceAccessStackComposer,
    ////ECSServiceStackComposer ecsServiceStackComposer,
    DecoratorOrchestrator decoratorOrchestrator) : BaseEnvironmentComposer<POCConsumerEnvironmentConfig>(decoratorOrchestrator)
{
    protected override EnvironmentOutputResult Create(POCConsumerEnvironmentConfig config)
    {
        var result = new EnvironmentOutputResult
        {
            Environment = config.Environment,
            RegionName = AWSConfigSettings.DefaultRegion,
        };

        // Github User Stack
        var githubUserStack = githubUserStackComposer.Create(new GithubUserStackConfig
        {
            DeployPermissions =
            [
                "iam:CreateRole",
                "iam:GetRolePolicy",

                // VPC Permissions
                "ec2:CreateVpc",
                "ec2:DeleteVpc",
                "ec2:DescribeVpcs",
                "ec2:ModifyVpcAttribute",
                "ec2:CreateSubnet",
                "ec2:DeleteSubnet",
                "ec2:DescribeSubnets",
                "ec2:ModifySubnetAttribute",
                "ec2:DescribeAccountAttributes",
                "ec2:CreateVpnGateway",
                "ec2:DeleteVpnGateway",
                "ec2:DescribeVpnGateways",
                "ec2:AttachVpnGateway",
                "ec2:DetachVpnGateway",
                "ec2:AssociateRouteTable",
                "ec2:DisassociateRouteTable",
                "ec2:ReplaceRouteTableAssociation",

                "ec2:DescribeSecurityGroups",
                "ec2:CreateSecurityGroup",
                "ec2:DeleteSecurityGroup",
                "ec2:AuthorizeSecurityGroupEgress",
                "ec2:AuthorizeSecurityGroupIngress",
                "ec2:DescribeSecurityGroupReferences",
                "ec2:DescribeStaleSecurityGroups",
                "ec2:RevokeSecurityGroupEgress",
                "ec2:RevokeSecurityGroupIngress",
                "ec2:DescribeAvailabilityZones",

                "rds:CreateDBSubnetGroup",
                "rds:DeleteDBSubnetGroup",

                "elasticache:AddTagsToResource",
                "elasticache:ListTagsForResource",
                "elasticache:RemoveTagsFromResource",

                "elasticache:CreateCacheSubnetGroup",
                "elasticache:DeleteCacheSubnetGroup",
                "elasticache:DescribeCacheSubnetGroups",
                "elasticache:ModifyCacheSubnetGroup",

                "elasticache:CreateReplicationGroup",
                "elasticache:DeleteReplicationGroup",
                "elasticache:ModifyReplicationGroup",
                "elasticache:DescribeReplicationGroups",

                "rds:AddTagsToResource",
                "rds:ListTagsForResource",
                "rds:RemoveTagsFromResource",

                // For RDS
                "rds:CreateDBCluster",
                "rds:CreateDBClusterParameterGroup",
                "rds:DescribeDBClusters",
                "rds:DeleteDBClusterParameterGroup",
                "rds:DescribeDBClusterParameterGroups",
                "rds:DescribeDBClusterParameters",
                "rds:DescribeDBClusterSnapshotAttributes",
                "rds:ModifyDBCluster",
                "rds:ModifyDBClusterParameterGroup",
                "rds:ModifyDBClusterSnapshotAttribute",
                "rds:PromoteReadReplicaDBCluster",
                "rds:ResetDBClusterParameterGroup",
                "rds:DescribeDBSubnetGroups",
                "rds:ModifyDBSubnetGroup",
                "rds:CreateDBSubnetGroup",
                "rds:DeleteDBSubnetGroup",

                // For ElastiCache
                "s3:GetBucketLocation",
                "ecs:CreateCluster",
                "ecs:CreateCapacityProvider",
                "ecs:CreateService",
                "ecs:CreateTaskSet",

                "ecs:DescribeClusters",
                "ecs:DeleteCluster",

                "ecs:RegisterTaskDefinition",
                "ecs:DescribeContainerInstances",
                "ecs:DescribeServices",
                "ecs:DescribeTaskDefinition",
                "ecs:DescribeTaskSets",
                "ecs:DescribeTasks",
                "ecs:TagResource",
                "ecs:UntagResource",
                "ecs:UpdateCluster",
                "ecs:UpdateCapacityProvider",
                "ecs:UpdateClusterSettings",
                "ecs:UpdateService",
                "ecs:UpdateTaskSet",

                // Delete
                "ecs:DeregisterTaskDefinition",
                "ecs:DeleteService",
            ]
        });

        var notificationResources = result.Add(githubUserStack, $"Cloud Formation\\Scripts\\1 - All\\4 - Create CloudFormation {githubUserStack.Stack.Name} Stack\\{config.Environment.EnvironmentName}");

        var serviceAccessStack = result.Add(() => ecrServiceAccessStackComposer.Create(new ERCServiceAccessStackConfig
        {
            AssetAccountId = config.AssetAccountId
        }));

        //result.Add(() => ecsServiceStackComposer.Create(new ECSServiceStackConfig
        //{
        //    AssetsAccountId = config.AssetAccountId,
        //    CreateServices = true,
        //    Import = new ImportModel(serviceAccessStack.Export),
        //    SecurityGroups = new WithFallback<dynamic>(new List<dynamic>
        //    {
        //        "sg-011391e7245be5841"
        //    }),
        //    DockerSubnets = new WithFallback<dynamic>(new List<dynamic>
        //    {
        //        "subnet-043e29e342367021a",
        //        "subnet-00bfd24e3590a4179",
        //        "subnet-0119877a12898e00e",
        //    }),
        //    LoadBalancer = null
        //}));

        return result;
    }
}
