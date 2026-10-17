namespace AppleStore.AWS.NimbusFactory.CLI.Features.POCAccount.POCEnvironmentComposer;

public class POCConsumerEnvironmentConfig : IHaveEnvironmentConfig
{
    public EnvironmentConfig Environment { get; set; }
    public string AssetAccountId { get; set; }
}