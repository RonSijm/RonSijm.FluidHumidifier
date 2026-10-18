// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerDatasetDatasetConfigFactory(Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig>
{

    internal InnerDatasetSessionConfigFactory SessionFactory { get; set; }

    protected override Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig Create()
    {
        var datasetConfigResult = CreateDatasetConfig();
        factoryAction?.Invoke(datasetConfigResult);

        return datasetConfigResult;
    }

    private Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig CreateDatasetConfig()
    {
        var datasetConfigResult = new Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig();

        return datasetConfigResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.DatasetTypes.DatasetConfig result)
    {
        base.CreateChildren(result);

        result.Session ??= SessionFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDatasetConfigFactoryExtensions
{
    public static CombinedResult<InnerDatasetDatasetConfigFactory, InnerDatasetSessionConfigFactory> WithSession(this InnerDatasetDatasetConfigFactory parentFactory, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null)
    {
        parentFactory.SessionFactory = new InnerDatasetSessionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionFactory);
    }

    public static CombinedResult<InnerDatasetDatasetConfigFactory, T1, InnerDatasetSessionConfigFactory> WithSession<T1>(this CombinedResult<InnerDatasetDatasetConfigFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSession(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetConfigFactory, InnerDatasetSessionConfigFactory> WithSession<T1>(this CombinedResult<T1, InnerDatasetDatasetConfigFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSession(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2, InnerDatasetSessionConfigFactory> WithSession<T1, T2>(this CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2, InnerDatasetSessionConfigFactory> WithSession<T1, T2>(this CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory, InnerDatasetSessionConfigFactory> WithSession<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2, T3, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3>(this CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2, T3, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory, T3, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetConfigFactory, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetConfigFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2, T3, T4, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDatasetConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2, T3, T4, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDatasetConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory, T3, T4, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDatasetConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetConfigFactory, T4, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetConfigFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetConfigFactory, InnerDatasetSessionConfigFactory> WithSession<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetConfigFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSession(combinedResult.T5, subFactoryAction).T2);
}
