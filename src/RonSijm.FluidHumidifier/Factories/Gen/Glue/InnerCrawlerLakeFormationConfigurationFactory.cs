// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCrawlerLakeFormationConfigurationFactory(Action<Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration>
{

    protected override Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration Create()
    {
        var lakeFormationConfigurationResult = CreateLakeFormationConfiguration();
        factoryAction?.Invoke(lakeFormationConfigurationResult);

        return lakeFormationConfigurationResult;
    }

    private Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration CreateLakeFormationConfiguration()
    {
        var lakeFormationConfigurationResult = new Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration();

        return lakeFormationConfigurationResult;
    }

} // End Of Class

public static class InnerCrawlerLakeFormationConfigurationFactoryExtensions
{
}
