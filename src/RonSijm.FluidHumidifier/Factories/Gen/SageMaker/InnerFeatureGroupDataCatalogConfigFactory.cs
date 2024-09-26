// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupDataCatalogConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig Create()
    {
        var dataCatalogConfigResult = CreateDataCatalogConfig();
        factoryAction?.Invoke(dataCatalogConfigResult);

        return dataCatalogConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig CreateDataCatalogConfig()
    {
        var dataCatalogConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig();

        return dataCatalogConfigResult;
    }

} // End Of Class

public static class InnerFeatureGroupDataCatalogConfigFactoryExtensions
{
}
