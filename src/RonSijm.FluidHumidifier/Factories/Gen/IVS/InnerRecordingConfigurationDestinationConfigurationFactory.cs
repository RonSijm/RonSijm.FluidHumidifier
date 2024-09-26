// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerRecordingConfigurationDestinationConfigurationFactory(Action<Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration>
{

    internal InnerRecordingConfigurationS3DestinationConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration Create()
    {
        var destinationConfigurationResult = CreateDestinationConfiguration();
        factoryAction?.Invoke(destinationConfigurationResult);

        return destinationConfigurationResult;
    }

    private Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration CreateDestinationConfiguration()
    {
        var destinationConfigurationResult = new Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration();

        return destinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerRecordingConfigurationDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3(this InnerRecordingConfigurationDestinationConfigurationFactory parentFactory, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerRecordingConfigurationS3DestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1>(this CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2, T3, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2, T3, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory, T3, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordingConfigurationDestinationConfigurationFactory, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordingConfigurationDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2, T3, T4, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerRecordingConfigurationDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2, T3, T4, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordingConfigurationDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory, T3, T4, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordingConfigurationDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordingConfigurationDestinationConfigurationFactory, T4, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordingConfigurationDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordingConfigurationDestinationConfigurationFactory, InnerRecordingConfigurationS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordingConfigurationDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
