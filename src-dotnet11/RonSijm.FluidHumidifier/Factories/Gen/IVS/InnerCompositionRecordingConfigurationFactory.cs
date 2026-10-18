// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionRecordingConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.RecordingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.RecordingConfiguration>
{

    internal InnerCompositionCompositionRecordingHlsConfigurationFactory HlsConfigurationFactory { get; set; }

    protected override Humidifier.IVS.CompositionTypes.RecordingConfiguration Create()
    {
        var recordingConfigurationResult = CreateRecordingConfiguration();
        factoryAction?.Invoke(recordingConfigurationResult);

        return recordingConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.RecordingConfiguration CreateRecordingConfiguration()
    {
        var recordingConfigurationResult = new Humidifier.IVS.CompositionTypes.RecordingConfiguration();

        return recordingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.CompositionTypes.RecordingConfiguration result)
    {
        base.CreateChildren(result);

        result.HlsConfiguration ??= HlsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCompositionRecordingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCompositionRecordingConfigurationFactory, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration(this InnerCompositionRecordingConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null)
    {
        parentFactory.HlsConfigurationFactory = new InnerCompositionCompositionRecordingHlsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HlsConfigurationFactory);
    }

    public static CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1>(this CombinedResult<InnerCompositionRecordingConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1>(this CombinedResult<T1, InnerCompositionRecordingConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2>(this CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2>(this CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2, T3, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3>(this CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2, T3, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory, T3, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionRecordingConfigurationFactory, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionRecordingConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2, T3, T4, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCompositionRecordingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2, T3, T4, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionRecordingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory, T3, T4, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionRecordingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionRecordingConfigurationFactory, T4, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionRecordingConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionRecordingConfigurationFactory, InnerCompositionCompositionRecordingHlsConfigurationFactory> WithHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionRecordingConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsConfiguration(combinedResult.T5, subFactoryAction).T2);
}
