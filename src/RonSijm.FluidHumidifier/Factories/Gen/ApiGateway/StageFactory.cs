// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class StageFactory(string resourceName = null, Action<Humidifier.ApiGateway.Stage> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Stage>(resourceName)
{

    internal List<InnerStageMethodSettingFactory> MethodSettingsFactories { get; set; } = [];

    internal InnerStageCanarySettingFactory CanarySettingFactory { get; set; }

    internal InnerStageAccessLogSettingFactory AccessLogSettingFactory { get; set; }

    protected override Humidifier.ApiGateway.Stage Create()
    {
        var stageResult = CreateStage();
        factoryAction?.Invoke(stageResult);

        return stageResult;
    }

    private Humidifier.ApiGateway.Stage CreateStage()
    {
        var stageResult = new Humidifier.ApiGateway.Stage
        {
            GivenName = InputResourceName,
        };

        return stageResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.Stage result)
    {
        base.CreateChildren(result);

        result.MethodSettings = MethodSettingsFactories.Any() ? MethodSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.CanarySetting ??= CanarySettingFactory?.Build();
        result.AccessLogSetting ??= AccessLogSettingFactory?.Build();
    }

} // End Of Class

public static class StageFactoryExtensions
{
    public static CombinedResult<StageFactory, InnerStageMethodSettingFactory> WithMethodSettings(this StageFactory parentFactory, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null)
    {
        var factory = new InnerStageMethodSettingFactory(subFactoryAction);
        parentFactory.MethodSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<StageFactory, InnerStageCanarySettingFactory> WithCanarySetting(this StageFactory parentFactory, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null)
    {
        parentFactory.CanarySettingFactory = new InnerStageCanarySettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanarySettingFactory);
    }

    public static CombinedResult<StageFactory, InnerStageAccessLogSettingFactory> WithAccessLogSetting(this StageFactory parentFactory, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null)
    {
        parentFactory.AccessLogSettingFactory = new InnerStageAccessLogSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessLogSettingFactory);
    }

    public static CombinedResult<StageFactory, T1, InnerStageMethodSettingFactory> WithMethodSettings<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithMethodSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageMethodSettingFactory> WithMethodSettings<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithMethodSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageMethodSettingFactory> WithMethodSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.MethodSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StageFactory, T1, InnerStageCanarySettingFactory> WithCanarySetting<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageCanarySettingFactory> WithCanarySetting<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StageFactory, T1, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T5, subFactoryAction));
}
