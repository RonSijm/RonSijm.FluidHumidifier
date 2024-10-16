// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class StageFactory(string resourceName = null, Action<Humidifier.IVS.Stage> factoryAction = null) : ResourceFactory<Humidifier.IVS.Stage>(resourceName)
{

    internal InnerStageAutoParticipantRecordingConfigurationFactory AutoParticipantRecordingConfigurationFactory { get; set; }

    protected override Humidifier.IVS.Stage Create()
    {
        var stageResult = CreateStage();
        factoryAction?.Invoke(stageResult);

        return stageResult;
    }

    private Humidifier.IVS.Stage CreateStage()
    {
        var stageResult = new Humidifier.IVS.Stage
        {
            GivenName = InputResourceName,
        };

        return stageResult;
    }
    public override void CreateChildren(Humidifier.IVS.Stage result)
    {
        base.CreateChildren(result);

        result.AutoParticipantRecordingConfiguration ??= AutoParticipantRecordingConfigurationFactory?.Build();
    }

} // End Of Class

public static class StageFactoryExtensions
{
    public static CombinedResult<StageFactory, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration(this StageFactory parentFactory, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null)
    {
        parentFactory.AutoParticipantRecordingConfigurationFactory = new InnerStageAutoParticipantRecordingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoParticipantRecordingConfigurationFactory);
    }

    public static CombinedResult<StageFactory, T1, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageAutoParticipantRecordingConfigurationFactory> WithAutoParticipantRecordingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoParticipantRecordingConfiguration(combinedResult.T5, subFactoryAction));
}
