// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class HookVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.HookVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.HookVersion>(resourceName)
{

    internal InnerHookVersionLoggingConfigFactory LoggingConfigFactory { get; set; }

    protected override Humidifier.CloudFormation.HookVersion Create()
    {
        var hookVersionResult = CreateHookVersion();
        factoryAction?.Invoke(hookVersionResult);

        return hookVersionResult;
    }

    private Humidifier.CloudFormation.HookVersion CreateHookVersion()
    {
        var hookVersionResult = new Humidifier.CloudFormation.HookVersion
        {
            GivenName = InputResourceName,
        };

        return hookVersionResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.HookVersion result)
    {
        base.CreateChildren(result);

        result.LoggingConfig ??= LoggingConfigFactory?.Build();
    }

} // End Of Class

public static class HookVersionFactoryExtensions
{
    public static CombinedResult<HookVersionFactory, InnerHookVersionLoggingConfigFactory> WithLoggingConfig(this HookVersionFactory parentFactory, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null)
    {
        parentFactory.LoggingConfigFactory = new InnerHookVersionLoggingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigFactory);
    }

    public static CombinedResult<HookVersionFactory, T1, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<HookVersionFactory, T1> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HookVersionFactory, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<T1, HookVersionFactory> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<HookVersionFactory, T1, T2, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<HookVersionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HookVersionFactory, T2, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, HookVersionFactory, T2> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HookVersionFactory, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, T2, HookVersionFactory> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<HookVersionFactory, T1, T2, T3, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<HookVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HookVersionFactory, T2, T3, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, HookVersionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HookVersionFactory, T3, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, HookVersionFactory, T3> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HookVersionFactory, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, HookVersionFactory> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<HookVersionFactory, T1, T2, T3, T4, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<HookVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HookVersionFactory, T2, T3, T4, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, HookVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HookVersionFactory, T3, T4, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, HookVersionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HookVersionFactory, T4, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HookVersionFactory, T4> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, HookVersionFactory, InnerHookVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HookVersionFactory> combinedResult, Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T5, subFactoryAction));
}
