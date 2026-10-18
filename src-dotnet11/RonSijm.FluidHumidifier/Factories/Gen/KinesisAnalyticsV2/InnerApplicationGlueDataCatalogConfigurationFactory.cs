// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationGlueDataCatalogConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration Create()
    {
        var glueDataCatalogConfigurationResult = CreateGlueDataCatalogConfiguration();
        factoryAction?.Invoke(glueDataCatalogConfigurationResult);

        return glueDataCatalogConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration CreateGlueDataCatalogConfiguration()
    {
        var glueDataCatalogConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration();

        return glueDataCatalogConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationGlueDataCatalogConfigurationFactoryExtensions
{
}
