namespace AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.AssetEnvironmentComposer;

public class AssetsEnvironmentFactoryConfig : IHaveEnvironmentConfig
{
    public List<EnvironmentConfig> AccountsIdsWithAccessToERC { get; set; } = [];
    public EnvironmentConfig Environment { get; set; }
}