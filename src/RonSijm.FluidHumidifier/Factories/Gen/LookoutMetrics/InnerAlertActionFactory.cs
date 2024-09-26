// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAlertActionFactory(Action<Humidifier.LookoutMetrics.AlertTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AlertTypes.Action>
{

    internal InnerAlertLambdaConfigurationFactory LambdaConfigurationFactory { get; set; }

    internal InnerAlertSNSConfigurationFactory SNSConfigurationFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AlertTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.LookoutMetrics.AlertTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.LookoutMetrics.AlertTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AlertTypes.Action result)
    {
        base.CreateChildren(result);

        result.LambdaConfiguration ??= LambdaConfigurationFactory?.Build();
        result.SNSConfiguration ??= SNSConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAlertActionFactoryExtensions
{
    public static CombinedResult<InnerAlertActionFactory, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration(this InnerAlertActionFactory parentFactory, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null)
    {
        parentFactory.LambdaConfigurationFactory = new InnerAlertLambdaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaConfigurationFactory);
    }

    public static CombinedResult<InnerAlertActionFactory, InnerAlertSNSConfigurationFactory> WithSNSConfiguration(this InnerAlertActionFactory parentFactory, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null)
    {
        parentFactory.SNSConfigurationFactory = new InnerAlertSNSConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SNSConfigurationFactory);
    }

    public static CombinedResult<InnerAlertActionFactory, T1, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1>(this CombinedResult<InnerAlertActionFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1>(this CombinedResult<T1, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2>(this CombinedResult<InnerAlertActionFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2>(this CombinedResult<T1, InnerAlertActionFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, T3, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3>(this CombinedResult<InnerAlertActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, T3, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAlertActionFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, T3, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlertActionFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlertActionFactory, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, T3, T4, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAlertActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, T3, T4, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlertActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, T3, T4, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlertActionFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlertActionFactory, T4, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlertActionFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAlertActionFactory, InnerAlertLambdaConfigurationFactory> WithLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1>(this CombinedResult<InnerAlertActionFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1>(this CombinedResult<T1, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2>(this CombinedResult<InnerAlertActionFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2>(this CombinedResult<T1, InnerAlertActionFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, T3, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3>(this CombinedResult<InnerAlertActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, T3, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAlertActionFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, T3, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlertActionFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlertActionFactory, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAlertActionFactory, T1, T2, T3, T4, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAlertActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlertActionFactory, T2, T3, T4, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlertActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlertActionFactory, T3, T4, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlertActionFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlertActionFactory, T4, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlertActionFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAlertActionFactory, InnerAlertSNSConfigurationFactory> WithSNSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlertActionFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSNSConfiguration(combinedResult.T5, subFactoryAction));
}
