// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class ObservabilityConfigurationFactory(string resourceName = null, Action<Humidifier.AppRunner.ObservabilityConfiguration> factoryAction = null) : ResourceFactory<Humidifier.AppRunner.ObservabilityConfiguration>(resourceName)
{

    internal InnerObservabilityConfigurationTraceConfigurationFactory TraceConfigurationFactory { get; set; }

    protected override Humidifier.AppRunner.ObservabilityConfiguration Create()
    {
        var observabilityConfigurationResult = CreateObservabilityConfiguration();
        factoryAction?.Invoke(observabilityConfigurationResult);

        return observabilityConfigurationResult;
    }

    private Humidifier.AppRunner.ObservabilityConfiguration CreateObservabilityConfiguration()
    {
        var observabilityConfigurationResult = new Humidifier.AppRunner.ObservabilityConfiguration
        {
            GivenName = InputResourceName,
        };

        return observabilityConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.ObservabilityConfiguration result)
    {
        base.CreateChildren(result);

        result.TraceConfiguration ??= TraceConfigurationFactory?.Build();
    }

} // End Of Class

public static class ObservabilityConfigurationFactoryExtensions
{
    public static CombinedResult<ObservabilityConfigurationFactory, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration(this ObservabilityConfigurationFactory parentFactory, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null)
    {
        parentFactory.TraceConfigurationFactory = new InnerObservabilityConfigurationTraceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TraceConfigurationFactory);
    }

    public static CombinedResult<ObservabilityConfigurationFactory, T1, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1>(this CombinedResult<ObservabilityConfigurationFactory, T1> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObservabilityConfigurationFactory, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1>(this CombinedResult<T1, ObservabilityConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ObservabilityConfigurationFactory, T1, T2, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2>(this CombinedResult<ObservabilityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObservabilityConfigurationFactory, T2, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2>(this CombinedResult<T1, ObservabilityConfigurationFactory, T2> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObservabilityConfigurationFactory, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2>(this CombinedResult<T1, T2, ObservabilityConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ObservabilityConfigurationFactory, T1, T2, T3, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3>(this CombinedResult<ObservabilityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObservabilityConfigurationFactory, T2, T3, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3>(this CombinedResult<T1, ObservabilityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObservabilityConfigurationFactory, T3, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ObservabilityConfigurationFactory, T3> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObservabilityConfigurationFactory, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ObservabilityConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ObservabilityConfigurationFactory, T1, T2, T3, T4, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3, T4>(this CombinedResult<ObservabilityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ObservabilityConfigurationFactory, T2, T3, T4, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ObservabilityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ObservabilityConfigurationFactory, T3, T4, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ObservabilityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ObservabilityConfigurationFactory, T4, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ObservabilityConfigurationFactory, T4> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ObservabilityConfigurationFactory, InnerObservabilityConfigurationTraceConfigurationFactory> WithTraceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ObservabilityConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceConfiguration(combinedResult.T5, subFactoryAction));
}
