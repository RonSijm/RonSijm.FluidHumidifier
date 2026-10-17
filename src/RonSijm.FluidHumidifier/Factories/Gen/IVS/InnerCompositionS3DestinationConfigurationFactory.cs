// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionS3DestinationConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration>
{

    internal InnerCompositionRecordingConfigurationFactory RecordingConfigurationFactory { get; set; }

    protected override Humidifier.IVS.CompositionTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.IVS.CompositionTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.CompositionTypes.S3DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.RecordingConfiguration ??= RecordingConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCompositionS3DestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCompositionS3DestinationConfigurationFactory, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration(this InnerCompositionS3DestinationConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null)
    {
        parentFactory.RecordingConfigurationFactory = new InnerCompositionRecordingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordingConfigurationFactory);
    }

    public static CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1>(this CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1>(this CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2>(this CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2>(this CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2, T3, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3>(this CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2, T3, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory, T3, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionS3DestinationConfigurationFactory, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2, T3, T4, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCompositionS3DestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2, T3, T4, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionS3DestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory, T3, T4, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionS3DestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionS3DestinationConfigurationFactory, T4, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionS3DestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionS3DestinationConfigurationFactory, InnerCompositionRecordingConfigurationFactory> WithRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingConfiguration(combinedResult.T5, subFactoryAction).T2);
}
