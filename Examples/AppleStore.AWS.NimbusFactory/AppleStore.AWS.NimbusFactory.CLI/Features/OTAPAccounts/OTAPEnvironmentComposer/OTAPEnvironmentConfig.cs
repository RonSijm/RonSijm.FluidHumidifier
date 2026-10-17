namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;

public class OTAPEnvironmentConfig : IHaveEnvironmentConfig
{
    public EnvironmentConfig Environment { get; set; }
    public string AssetAccountId { get; set; }
}