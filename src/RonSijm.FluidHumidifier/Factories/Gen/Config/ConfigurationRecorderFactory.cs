// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class ConfigurationRecorderFactory(string resourceName = null, Action<Humidifier.Config.ConfigurationRecorder> factoryAction = null) : ResourceFactory<Humidifier.Config.ConfigurationRecorder>(resourceName)
{

    internal InnerConfigurationRecorderRecordingGroupFactory RecordingGroupFactory { get; set; }

    internal InnerConfigurationRecorderRecordingModeFactory RecordingModeFactory { get; set; }

    protected override Humidifier.Config.ConfigurationRecorder Create()
    {
        var configurationRecorderResult = CreateConfigurationRecorder();
        factoryAction?.Invoke(configurationRecorderResult);

        return configurationRecorderResult;
    }

    private Humidifier.Config.ConfigurationRecorder CreateConfigurationRecorder()
    {
        var configurationRecorderResult = new Humidifier.Config.ConfigurationRecorder
        {
            GivenName = InputResourceName,
        };

        return configurationRecorderResult;
    }
    public override void CreateChildren(Humidifier.Config.ConfigurationRecorder result)
    {
        base.CreateChildren(result);

        result.RecordingGroup ??= RecordingGroupFactory?.Build();
        result.RecordingMode ??= RecordingModeFactory?.Build();
    }

} // End Of Class

public static class ConfigurationRecorderFactoryExtensions
{
    public static CombinedResult<ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup(this ConfigurationRecorderFactory parentFactory, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null)
    {
        parentFactory.RecordingGroupFactory = new InnerConfigurationRecorderRecordingGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordingGroupFactory);
    }

    public static CombinedResult<ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode(this ConfigurationRecorderFactory parentFactory, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null)
    {
        parentFactory.RecordingModeFactory = new InnerConfigurationRecorderRecordingModeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordingModeFactory);
    }

    public static CombinedResult<ConfigurationRecorderFactory, T1, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1>(this CombinedResult<ConfigurationRecorderFactory, T1> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1>(this CombinedResult<T1, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2>(this CombinedResult<ConfigurationRecorderFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2>(this CombinedResult<T1, ConfigurationRecorderFactory, T2> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2>(this CombinedResult<T1, T2, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3>(this CombinedResult<ConfigurationRecorderFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3>(this CombinedResult<T1, ConfigurationRecorderFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationRecorderFactory, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, T4, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3, T4>(this CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, T4, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, T4, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, T4, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingGroupFactory> WithRecordingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingGroup(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1>(this CombinedResult<ConfigurationRecorderFactory, T1> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1>(this CombinedResult<T1, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2>(this CombinedResult<ConfigurationRecorderFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2>(this CombinedResult<T1, ConfigurationRecorderFactory, T2> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2>(this CombinedResult<T1, T2, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3>(this CombinedResult<ConfigurationRecorderFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3>(this CombinedResult<T1, ConfigurationRecorderFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationRecorderFactory, T3> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, T4, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3, T4>(this CombinedResult<ConfigurationRecorderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, T4, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationRecorderFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, T4, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationRecorderFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, T4, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationRecorderFactory, T4> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationRecorderFactory, InnerConfigurationRecorderRecordingModeFactory> WithRecordingMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationRecorderFactory> combinedResult, Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingMode(combinedResult.T5, subFactoryAction));
}
