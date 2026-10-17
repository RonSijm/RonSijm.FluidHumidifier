namespace AppleStore.AWS.NimbusFactory.CLI;

public class EnvironmentResultFactory(AssetsEnvironmentComposer assetsEnvironmentComposer, Func<OTAPEnvironmentComposer> otapEnvironmentComposerFactory)
{
    public List<EnvironmentOutputResult> CreateEnvironments()
    {
        var environments = new List<EnvironmentConfig>
        {
            new(AccountConfigSettings.AssetAccountName, AccountConfigSettings.AssetAccountId, AWSConfigSettings.DefaultRegion),
            new("poc", AccountConfigSettings.POCAccountId, AWSConfigSettings.DefaultRegion),
            new("dev", AccountConfigSettings.DevAccountId, AWSConfigSettings.DefaultRegion),
            new("staging", AccountConfigSettings.StagingAccountId, AWSConfigSettings.DefaultRegion),
            new("preprod", AccountConfigSettings.PreprodAccountId, AWSConfigSettings.DefaultRegion),
            new("prod", AccountConfigSettings.ProdAccountId, AWSConfigSettings.DefaultRegion),
        };

        // Asset Environment
        var accountsWithAccessToECR = environments.Where(x => x.EnvironmentName != AccountConfigSettings.AssetAccountName).ToList();

        var assetEnvironment = assetsEnvironmentComposer.CreateResource(new AssetsEnvironmentFactoryConfig
        {
            AccountsIdsWithAccessToERC = accountsWithAccessToECR,
            Environment = environments.First(x => x.EnvironmentName == AccountConfigSettings.AssetAccountName)
        });

        //// POC Environment
        //var pocEnvironmentFactory = serviceProvider.GetRequiredService<POCConsumerEnvironmentComposer>();
        //var pocEnvironment = pocEnvironmentFactory.CreateResource(new POCConsumerEnvironmentConfig
        //{
        //    Environment = environments.First(x => x.EnvironmentName == "poc"),
        //    AssetAccountId = environments.First(x => x.EnvironmentName == AccountConfigSettings.AssetAccountName).AWSAccountId
        //});

        // Dev Environment
        var developmentEnvironmentFactory = otapEnvironmentComposerFactory();
        var devEnvironment = developmentEnvironmentFactory.CreateResource(new OTAPEnvironmentConfig
        {
            Environment = environments.First(x => x.EnvironmentName == "dev"),
            AssetAccountId = environments.First(x => x.EnvironmentName == AccountConfigSettings.AssetAccountName).AWSAccountId
        });

        // Staging Environment
        var stagingEnvironmentFactory = otapEnvironmentComposerFactory();
        var stagingEnvironment = stagingEnvironmentFactory.CreateResource(new OTAPEnvironmentConfig
        {
            Environment = environments.First(x => x.EnvironmentName == "staging"),
            AssetAccountId = environments.First(x => x.EnvironmentName == AccountConfigSettings.AssetAccountName).AWSAccountId
        });

        // Production Environment
        var productionEnvironmentFactory = otapEnvironmentComposerFactory();
        var productionEnvironment = productionEnvironmentFactory.CreateResource(new OTAPEnvironmentConfig
        {
            Environment = environments.First(x => x.EnvironmentName == "prod"),
            AssetAccountId = environments.First(x => x.EnvironmentName == AccountConfigSettings.AssetAccountName).AWSAccountId
        });

        // Write Scripts to Files
        var allEnvironments = new List<EnvironmentOutputResult>
        {
            //assetEnvironment,
            //   pocEnvironment,
            devEnvironment,
            stagingEnvironment,
            productionEnvironment
        };

        allEnvironments.WriteScriptsToFiles();

        return allEnvironments;
    }
}