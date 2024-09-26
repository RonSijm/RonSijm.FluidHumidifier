// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerDataLakeLifecycleConfigurationFactory(Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration>
{

    internal InnerDataLakeExpirationFactory ExpirationFactory { get; set; }

    protected override Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration result)
    {
        base.CreateChildren(result);

        result.Expiration ??= ExpirationFactory?.Build();
    }

} // End Of Class

public static class InnerDataLakeLifecycleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataLakeLifecycleConfigurationFactory, InnerDataLakeExpirationFactory> WithExpiration(this InnerDataLakeLifecycleConfigurationFactory parentFactory, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null)
    {
        parentFactory.ExpirationFactory = new InnerDataLakeExpirationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExpirationFactory);
    }

    public static CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, InnerDataLakeExpirationFactory> WithExpiration<T1>(this CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, InnerDataLakeExpirationFactory> WithExpiration<T1>(this CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2, InnerDataLakeExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2, InnerDataLakeExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory, InnerDataLakeExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2, T3, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2, T3, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory, T3, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataLakeLifecycleConfigurationFactory, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataLakeLifecycleConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2, T3, T4, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<InnerDataLakeLifecycleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2, T3, T4, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataLakeLifecycleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory, T3, T4, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataLakeLifecycleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataLakeLifecycleConfigurationFactory, T4, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataLakeLifecycleConfigurationFactory, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataLakeLifecycleConfigurationFactory, InnerDataLakeExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataLakeLifecycleConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T5, subFactoryAction));
}
