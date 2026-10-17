using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;

namespace FruitVendor.AWS.NimbusFactory.CLI;

public class EnvironmentResultFactory(Func<OTAPEnvironmentComposer> otapEnvironmentComposerFactory)
{
    public List<EnvironmentOutputResult> CreateEnvironments()
    {
        var environments = new List<EnvironmentConfig>
        {
            new("fruitvendor-prod", AccountConfigSettings.ProdAccountId, AWSConfigSettings.RegionName),
        };

        // Asset Environment
        var accountsWithAccessToECR = environments.ToList();


        // Production Environment
        var productionEnvironmentFactory = otapEnvironmentComposerFactory();
        var productionEnvironment = productionEnvironmentFactory.CreateResource(new OTAPEnvironmentConfig
        {
            Environment = environments.First(x => x.EnvironmentName == "fruitvendor-prod"),
        });

        // Write Scripts to Files
        var allEnvironments = new List<EnvironmentOutputResult>
        {
            productionEnvironment
        };

        allEnvironments.WriteScriptsToFiles();

        return allEnvironments;
    }
}