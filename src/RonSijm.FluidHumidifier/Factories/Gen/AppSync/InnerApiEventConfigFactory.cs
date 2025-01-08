// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerApiEventConfigFactory(Action<Humidifier.AppSync.ApiTypes.EventConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ApiTypes.EventConfig>
{

    internal InnerApiEventLogConfigFactory LogConfigFactory { get; set; }

    protected override Humidifier.AppSync.ApiTypes.EventConfig Create()
    {
        var eventConfigResult = CreateEventConfig();
        factoryAction?.Invoke(eventConfigResult);

        return eventConfigResult;
    }

    private Humidifier.AppSync.ApiTypes.EventConfig CreateEventConfig()
    {
        var eventConfigResult = new Humidifier.AppSync.ApiTypes.EventConfig();

        return eventConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ApiTypes.EventConfig result)
    {
        base.CreateChildren(result);

        result.LogConfig ??= LogConfigFactory?.Build();
    }

} // End Of Class

public static class InnerApiEventConfigFactoryExtensions
{
    public static CombinedResult<InnerApiEventConfigFactory, InnerApiEventLogConfigFactory> WithLogConfig(this InnerApiEventConfigFactory parentFactory, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null)
    {
        parentFactory.LogConfigFactory = new InnerApiEventLogConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigFactory);
    }

    public static CombinedResult<InnerApiEventConfigFactory, T1, InnerApiEventLogConfigFactory> WithLogConfig<T1>(this CombinedResult<InnerApiEventConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApiEventConfigFactory, InnerApiEventLogConfigFactory> WithLogConfig<T1>(this CombinedResult<T1, InnerApiEventConfigFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApiEventConfigFactory, T1, T2, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<InnerApiEventConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApiEventConfigFactory, T2, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<T1, InnerApiEventConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApiEventConfigFactory, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<T1, T2, InnerApiEventConfigFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApiEventConfigFactory, T1, T2, T3, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<InnerApiEventConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApiEventConfigFactory, T2, T3, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, InnerApiEventConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApiEventConfigFactory, T3, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerApiEventConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApiEventConfigFactory, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApiEventConfigFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApiEventConfigFactory, T1, T2, T3, T4, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<InnerApiEventConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApiEventConfigFactory, T2, T3, T4, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerApiEventConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApiEventConfigFactory, T3, T4, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApiEventConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApiEventConfigFactory, T4, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApiEventConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApiEventConfigFactory, InnerApiEventLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApiEventConfigFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventLogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T5, subFactoryAction));
}
