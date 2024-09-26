// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class StageFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Stage> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Stage>(resourceName)
{

    internal InnerStageAccessLogSettingsFactory AccessLogSettingsFactory { get; set; }

    internal InnerStageRouteSettingsFactory DefaultRouteSettingsFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.Stage Create()
    {
        var stageResult = CreateStage();
        factoryAction?.Invoke(stageResult);

        return stageResult;
    }

    private Humidifier.ApiGatewayV2.Stage CreateStage()
    {
        var stageResult = new Humidifier.ApiGatewayV2.Stage
        {
            GivenName = InputResourceName,
        };

        return stageResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.Stage result)
    {
        base.CreateChildren(result);

        result.AccessLogSettings ??= AccessLogSettingsFactory?.Build();
        result.DefaultRouteSettings ??= DefaultRouteSettingsFactory?.Build();
    }

} // End Of Class

public static class StageFactoryExtensions
{
    public static CombinedResult<StageFactory, InnerStageAccessLogSettingsFactory> WithAccessLogSettings(this StageFactory parentFactory, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null)
    {
        parentFactory.AccessLogSettingsFactory = new InnerStageAccessLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessLogSettingsFactory);
    }

    public static CombinedResult<StageFactory, InnerStageRouteSettingsFactory> WithDefaultRouteSettings(this StageFactory parentFactory, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null)
    {
        parentFactory.DefaultRouteSettingsFactory = new InnerStageRouteSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultRouteSettingsFactory);
    }

    public static CombinedResult<StageFactory, T1, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageAccessLogSettingsFactory> WithAccessLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLogSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StageFactory, T1, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1>(this CombinedResult<StageFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1>(this CombinedResult<T1, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2>(this CombinedResult<StageFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2>(this CombinedResult<T1, StageFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2>(this CombinedResult<T1, T2, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3>(this CombinedResult<StageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3>(this CombinedResult<T1, StageFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3>(this CombinedResult<T1, T2, StageFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StageFactory, T1, T2, T3, T4, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3, T4>(this CombinedResult<StageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StageFactory, T2, T3, T4, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3, T4>(this CombinedResult<T1, StageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StageFactory, T3, T4, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, StageFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StageFactory, T4, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StageFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StageFactory, InnerStageRouteSettingsFactory> WithDefaultRouteSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StageFactory> combinedResult, Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRouteSettings(combinedResult.T5, subFactoryAction));
}
