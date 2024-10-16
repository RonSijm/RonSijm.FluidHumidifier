// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowMetadataCatalogConfigFactory(Action<Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig>
{

    internal InnerFlowGlueDataCatalogFactory GlueDataCatalogFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig Create()
    {
        var metadataCatalogConfigResult = CreateMetadataCatalogConfig();
        factoryAction?.Invoke(metadataCatalogConfigResult);

        return metadataCatalogConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig CreateMetadataCatalogConfig()
    {
        var metadataCatalogConfigResult = new Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig();

        return metadataCatalogConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig result)
    {
        base.CreateChildren(result);

        result.GlueDataCatalog ??= GlueDataCatalogFactory?.Build();
    }

} // End Of Class

public static class InnerFlowMetadataCatalogConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowMetadataCatalogConfigFactory, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog(this InnerFlowMetadataCatalogConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null)
    {
        parentFactory.GlueDataCatalogFactory = new InnerFlowGlueDataCatalogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueDataCatalogFactory);
    }

    public static CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1>(this CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1>(this CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2>(this CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2>(this CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2>(this CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2, T3, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3>(this CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2, T3, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory, T3, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMetadataCatalogConfigFactory, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowMetadataCatalogConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2, T3, T4, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<InnerFlowMetadataCatalogConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2, T3, T4, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowMetadataCatalogConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory, T3, T4, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowMetadataCatalogConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMetadataCatalogConfigFactory, T4, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowMetadataCatalogConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowMetadataCatalogConfigFactory, InnerFlowGlueDataCatalogFactory> WithGlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowMetadataCatalogConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalog(combinedResult.T5, subFactoryAction));
}
