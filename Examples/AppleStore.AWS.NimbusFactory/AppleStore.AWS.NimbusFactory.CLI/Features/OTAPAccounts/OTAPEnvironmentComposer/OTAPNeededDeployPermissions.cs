namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;

public static class OTAPNeededDeployPermissions
{
    public static List<string> IAMPermissions { get; } =
    [
        "iam:CreateRole",
        "iam:GetRolePolicy",
    ];

    public static List<string> EC2Permissions { get; } =
    [
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

        "ec2:CreateNetworkAcl",
        "ec2:CreateNetworkAclEntry",
        "ec2:DeleteNetworkAcl",
        "ec2:DeleteNetworkAclEntry",
        "ec2:DescribeNetworkAcls",
        "ec2:DescribeNetworkInterfaceAttribute",
        "ec2:DescribeNetworkInterfaces",

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
        "ec2:ReplaceNetworkAclAssociation",

        "ec2:AllocateAddress",
        "ec2:AssignPrivateIpAddresses",
        "ec2:AssociateAddress",
        "ec2:DescribeAddresses",
        "ec2:DescribeMovingAddresses",
        "ec2:DisassociateAddress",
        "ec2:MoveAddressToVpc",
        "ec2:ReleaseAddress",
        "ec2:RestoreAddressToClassic",
        "ec2:UnassignPrivateIpAddresses",

        "ec2:CreateInternetGateway",
        "ec2:DescribeInternetGateways",
        "ec2:AttachInternetGateway",
        "ec2:DeleteInternetGateway",
        "ec2:DetachInternetGateway",
        "ec2:CreateRoute",
        "ec2:DeleteRoute",
        "ec2:ReplaceRoute",

        "ec2:CreateNetworkInterface",
        "ec2:AttachNetworkInterface",
        "ec2:DeleteNetworkInterface",
        "ec2:DescribeNetworkInterfaceAttribute",
        "ec2:DescribeNetworkInterfaces",
        "ec2:DetachNetworkInterface",
        "ec2:ModifyNetworkInterfaceAttribute",
        "ec2:ResetNetworkInterfaceAttribute",

        "ec2:CreateRouteTable",
        "ec2:DeleteRouteTable",
        "ec2:DescribeRouteTables",
        "ec2:DescribeVpnGateways",
        "ec2:DetachVpnGateway",
        "ec2:CreateVpcEndpoint",
        "ec2:DeleteVpcEndpoints",
        "ec2:DescribeVpcEndpoints",
        "ec2:DescribeVpcEndpointServices",
        "ec2:ModifyVpcEndpoint",

        "ec2:CreateNatGateway",
        "ec2:DeleteNatGateway",
        "ec2:DescribeNatGateways",
    ];

    public static List<string> ElasticachePermissions { get; } =
    [
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
    ];

    public static List<string> RDSPermissions { get; } =
    [
        "rds:CreateDBSubnetGroup",
        "rds:DeleteDBSubnetGroup",

        "rds:CreateDBCluster",
        "rds:CreateDBClusterParameterGroup",
        "rds:CreateDBClusterSnapshot",
        "rds:CopyDBClusterSnapshot",
        "rds:DeleteDBClusterSnapshot",
        "rds:RestoreDBClusterFromSnapshot",
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

        "rds:AddTagsToResource",
        "rds:RemoveTagsFromResource",
        "rds:ListTagsForResource",

        // For Backups
        "backup:CreateBackupVault",
        "backup:DeleteBackupVault",
        "backup:DescribeBackupVault",
        "backup:UpdateBackupVault",
        "backup:CreateBackupPlan",
        "backup:UpdateBackupPlan",
        "backup:DeleteBackupPlan",
        "backup:DescribeBackupPlan",
        "backup:CreateBackupSelection",
        "backup:UpdateBackupSelection",
        "backup:DeleteBackupSelection",
        "backup:StartBackupJob",
        "backup:DeleteBackup",
        "backup:CopyBackup",
        "backup:ListBackupVaults",
        "backup:ListBackupPlans",
        "backup:ListBackupSelections",
        "backup:ListBackupJobs",
        "backup:DescribeRecoveryPoint",
        "backup:StartRestoreJob",
        "backup:DescribeRestoreJob",
    ];

    // Should probably remove these after deploying, since we don't want CF to delete our database.
    public static List<string> RDSUpgradePermissions { get; } =
    [
        "rds:DeleteDBCluster"
    ];

    public static List<string> S3Permissions { get; } =
    [
        // For ElastiCache
        "s3:GetBucketLocation",
    ];

    public static List<string> ECSPermissions { get; } =
    [
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

        "ecs:DeregisterTaskDefinition",
        "ecs:DeleteService",
    ];

    public static List<string> LoadBalancerPermissions { get; } =
    [
        "elasticloadbalancing:DescribeTargetGroups",
        "elasticloadbalancing:CreateLoadBalancer",
        "elasticloadbalancing:CreateListener",
        "elasticloadbalancing:AddTags",
        "elasticloadbalancing:AddListenerCertificates",
        "elasticloadbalancing:CreateRule",
        "elasticloadbalancing:CreateTargetGroup",
        "elasticloadbalancing:DeleteListener",
        "elasticloadbalancing:DeleteLoadBalancer",
        "elasticloadbalancing:DeleteRule",
        "elasticloadbalancing:DeleteTargetGroup",
        "elasticloadbalancing:DeregisterTargets",
        "elasticloadbalancing:DescribeListenerCertificates",
        "elasticloadbalancing:DescribeListeners",
        "elasticloadbalancing:DescribeLoadBalancerAttributes",
        "elasticloadbalancing:DescribeLoadBalancers",
        "elasticloadbalancing:DescribeRules",
        "elasticloadbalancing:DescribeTags",
        "elasticloadbalancing:DescribeTargetGroupAttributes",
        "elasticloadbalancing:DescribeTargetGroups",
        "elasticloadbalancing:DescribeTargetHealth",
        "elasticloadbalancing:GetResourcePolicy",
        "elasticloadbalancing:ModifyListener",
        "elasticloadbalancing:ModifyLoadBalancerAttributes",
        "elasticloadbalancing:ModifyRule",
        "elasticloadbalancing:ModifyTargetGroup",
        "elasticloadbalancing:ModifyTargetGroupAttributes",
        "elasticloadbalancing:RegisterTargets",
        "elasticloadbalancing:RemoveListenerCertificates",
        "elasticloadbalancing:RemoveTags",
        "elasticloadbalancing:SetRulePriorities",
        "elasticloadbalancing:SetSecurityGroups",
        "elasticloadbalancing:SetSubnets",
    ];
}