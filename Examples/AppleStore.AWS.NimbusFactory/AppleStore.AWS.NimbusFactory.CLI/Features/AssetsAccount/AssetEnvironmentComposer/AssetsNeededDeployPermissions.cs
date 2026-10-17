namespace AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.AssetEnvironmentComposer;

public static class AssetsNeededDeployPermissions
{
    public static List<string> AssetPermissions { get; } =
    [
        "iam:CreateRole",
        "iam:GetRolePolicy",

        "ecr:CreateRepository",
        "ecr:DeleteRepository",
        "ecr:TagResource",

        "ecr:SetRepositoryPolicy"
    ];
}