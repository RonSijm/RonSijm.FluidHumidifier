// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigTelemetrySinkDataFactory(Action<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData>
{

    internal InnerConfigKinesisDataStreamDataFactory KinesisDataStreamDataFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.TelemetrySinkData Create()
    {
        var telemetrySinkDataResult = CreateTelemetrySinkData();
        factoryAction?.Invoke(telemetrySinkDataResult);

        return telemetrySinkDataResult;
    }

    private Humidifier.GroundStation.ConfigTypes.TelemetrySinkData CreateTelemetrySinkData()
    {
        var telemetrySinkDataResult = new Humidifier.GroundStation.ConfigTypes.TelemetrySinkData();

        return telemetrySinkDataResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.TelemetrySinkData result)
    {
        base.CreateChildren(result);

        result.KinesisDataStreamData ??= KinesisDataStreamDataFactory?.Build();
    }

} // End Of Class

public static class InnerConfigTelemetrySinkDataFactoryExtensions
{
    public static CombinedResult<InnerConfigTelemetrySinkDataFactory, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData(this InnerConfigTelemetrySinkDataFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null)
    {
        parentFactory.KinesisDataStreamDataFactory = new InnerConfigKinesisDataStreamDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KinesisDataStreamDataFactory);
    }

    public static CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1>(this CombinedResult<InnerConfigTelemetrySinkDataFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1>(this CombinedResult<T1, InnerConfigTelemetrySinkDataFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2>(this CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2>(this CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2, T3, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3>(this CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2, T3, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3>(this CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory, T3, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkDataFactory, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkDataFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2, T3, T4, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3, T4>(this CombinedResult<InnerConfigTelemetrySinkDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2, T3, T4, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigTelemetrySinkDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory, T3, T4, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigTelemetrySinkDataFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkDataFactory, T4, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigTelemetrySinkDataFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigTelemetrySinkDataFactory, InnerConfigKinesisDataStreamDataFactory> WithKinesisDataStreamData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigTelemetrySinkDataFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisDataStreamData(combinedResult.T5, subFactoryAction).T2);
}
