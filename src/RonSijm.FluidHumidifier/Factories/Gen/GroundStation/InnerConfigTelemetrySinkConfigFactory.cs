// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigTelemetrySinkConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig>
{

    internal InnerConfigTelemetrySinkDataFactory TelemetrySinkDataFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig Create()
    {
        var telemetrySinkConfigResult = CreateTelemetrySinkConfig();
        factoryAction?.Invoke(telemetrySinkConfigResult);

        return telemetrySinkConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig CreateTelemetrySinkConfig()
    {
        var telemetrySinkConfigResult = new Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig();

        return telemetrySinkConfigResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig result)
    {
        base.CreateChildren(result);

        result.TelemetrySinkData ??= TelemetrySinkDataFactory?.Build();
    }

} // End Of Class

public static class InnerConfigTelemetrySinkConfigFactoryExtensions
{
    public static CombinedResult<InnerConfigTelemetrySinkConfigFactory, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData(this InnerConfigTelemetrySinkConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null)
    {
        parentFactory.TelemetrySinkDataFactory = new InnerConfigTelemetrySinkDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TelemetrySinkDataFactory);
    }

    public static CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1>(this CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1>(this CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2>(this CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2>(this CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2, T3, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3>(this CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2, T3, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3>(this CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory, T3, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkConfigFactory, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2, T3, T4, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3, T4>(this CombinedResult<InnerConfigTelemetrySinkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2, T3, T4, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigTelemetrySinkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory, T3, T4, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkConfigFactory, T4, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigTelemetrySinkConfigFactory, InnerConfigTelemetrySinkDataFactory> WithTelemetrySinkData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigTelemetrySinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetrySinkData(combinedResult.T5, subFactoryAction).T2);
}
