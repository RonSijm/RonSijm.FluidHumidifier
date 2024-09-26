// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationInitialCapacityConfigKeyValuePairFactory(Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair>
{

    internal InnerApplicationInitialCapacityConfigFactory ValueFactory { get; set; }

    protected override Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair Create()
    {
        var initialCapacityConfigKeyValuePairResult = CreateInitialCapacityConfigKeyValuePair();
        factoryAction?.Invoke(initialCapacityConfigKeyValuePairResult);

        return initialCapacityConfigKeyValuePairResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair CreateInitialCapacityConfigKeyValuePair()
    {
        var initialCapacityConfigKeyValuePairResult = new Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair();

        return initialCapacityConfigKeyValuePairResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfigKeyValuePair result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationInitialCapacityConfigKeyValuePairFactoryExtensions
{
    public static CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, InnerApplicationInitialCapacityConfigFactory> WithValue(this InnerApplicationInitialCapacityConfigKeyValuePairFactory parentFactory, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerApplicationInitialCapacityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, InnerApplicationInitialCapacityConfigFactory> WithValue<T1>(this CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, InnerApplicationInitialCapacityConfigFactory> WithValue<T1>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2>(this CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2, T3, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2, T3, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T3, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigKeyValuePairFactory, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigKeyValuePairFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2, T3, T4, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerApplicationInitialCapacityConfigKeyValuePairFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2, T3, T4, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T3, T4, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T4, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigKeyValuePairFactory, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationInitialCapacityConfigKeyValuePairFactory, InnerApplicationInitialCapacityConfigFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationInitialCapacityConfigKeyValuePairFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
