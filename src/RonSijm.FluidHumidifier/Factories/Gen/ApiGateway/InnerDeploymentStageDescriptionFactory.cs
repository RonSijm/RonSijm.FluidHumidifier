// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDeploymentStageDescriptionFactory(Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DeploymentTypes.StageDescription>
{

    internal InnerDeploymentCanarySettingFactory CanarySettingFactory { get; set; }

    internal InnerDeploymentAccessLogSettingFactory AccessLogSettingFactory { get; set; }

    protected override Humidifier.ApiGateway.DeploymentTypes.StageDescription Create()
    {
        var stageDescriptionResult = CreateStageDescription();
        factoryAction?.Invoke(stageDescriptionResult);

        return stageDescriptionResult;
    }

    private Humidifier.ApiGateway.DeploymentTypes.StageDescription CreateStageDescription()
    {
        var stageDescriptionResult = new Humidifier.ApiGateway.DeploymentTypes.StageDescription();

        return stageDescriptionResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.DeploymentTypes.StageDescription result)
    {
        base.CreateChildren(result);

        result.CanarySetting ??= CanarySettingFactory?.Build();
        result.AccessLogSetting ??= AccessLogSettingFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentStageDescriptionFactoryExtensions
{
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, InnerDeploymentCanarySettingFactory> WithCanarySetting(this InnerDeploymentStageDescriptionFactory parentFactory, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null)
    {
        parentFactory.CanarySettingFactory = new InnerDeploymentCanarySettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanarySettingFactory);
    }

    public static CombinedResult<InnerDeploymentStageDescriptionFactory, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting(this InnerDeploymentStageDescriptionFactory parentFactory, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null)
    {
        parentFactory.AccessLogSettingFactory = new InnerDeploymentAccessLogSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessLogSettingFactory);
    }

    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, T4, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, T4, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, T4, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, T4, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentStageDescriptionFactory, InnerDeploymentCanarySettingFactory> WithCanarySetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySetting(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, T4, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentStageDescriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, T4, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentStageDescriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, T4, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentStageDescriptionFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, T4, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentStageDescriptionFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentStageDescriptionFactory, InnerDeploymentAccessLogSettingFactory> WithAccessLogSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentStageDescriptionFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSetting(combinedResult.T5, subFactoryAction));
}
