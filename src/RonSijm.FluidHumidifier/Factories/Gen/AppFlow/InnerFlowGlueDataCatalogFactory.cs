// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowGlueDataCatalogFactory(Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.GlueDataCatalog>
{

    protected override Humidifier.AppFlow.FlowTypes.GlueDataCatalog Create()
    {
        var glueDataCatalogResult = CreateGlueDataCatalog();
        factoryAction?.Invoke(glueDataCatalogResult);

        return glueDataCatalogResult;
    }

    private Humidifier.AppFlow.FlowTypes.GlueDataCatalog CreateGlueDataCatalog()
    {
        var glueDataCatalogResult = new Humidifier.AppFlow.FlowTypes.GlueDataCatalog();

        return glueDataCatalogResult;
    }

} // End Of Class

public static class InnerFlowGlueDataCatalogFactoryExtensions
{
}
