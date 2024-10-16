// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VerifiedAccessInstanceFactory(string resourceName = null, Action<Humidifier.EC2.VerifiedAccessInstance> factoryAction = null) : ResourceFactory<Humidifier.EC2.VerifiedAccessInstance>(resourceName)
{

    internal List<InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> VerifiedAccessTrustProvidersFactories { get; set; } = [];

    internal InnerVerifiedAccessInstanceVerifiedAccessLogsFactory LoggingConfigurationsFactory { get; set; }

    protected override Humidifier.EC2.VerifiedAccessInstance Create()
    {
        var verifiedAccessInstanceResult = CreateVerifiedAccessInstance();
        factoryAction?.Invoke(verifiedAccessInstanceResult);

        return verifiedAccessInstanceResult;
    }

    private Humidifier.EC2.VerifiedAccessInstance CreateVerifiedAccessInstance()
    {
        var verifiedAccessInstanceResult = new Humidifier.EC2.VerifiedAccessInstance
        {
            GivenName = InputResourceName,
        };

        return verifiedAccessInstanceResult;
    }
    public override void CreateChildren(Humidifier.EC2.VerifiedAccessInstance result)
    {
        base.CreateChildren(result);

        result.VerifiedAccessTrustProviders = VerifiedAccessTrustProvidersFactories.Any() ? VerifiedAccessTrustProvidersFactories.Select(x => x.Build()).ToList() : null;
        result.LoggingConfigurations ??= LoggingConfigurationsFactory?.Build();
    }

} // End Of Class

public static class VerifiedAccessInstanceFactoryExtensions
{
    public static CombinedResult<VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders(this VerifiedAccessInstanceFactory parentFactory, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null)
    {
        var factory = new InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory(subFactoryAction);
        parentFactory.VerifiedAccessTrustProvidersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations(this VerifiedAccessInstanceFactory parentFactory, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null)
    {
        parentFactory.LoggingConfigurationsFactory = new InnerVerifiedAccessInstanceVerifiedAccessLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigurationsFactory);
    }

    public static CombinedResult<VerifiedAccessInstanceFactory, T1, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1>(this CombinedResult<VerifiedAccessInstanceFactory, T1> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1>(this CombinedResult<T1, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3>(this CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3, T4>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3, T4>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, T4, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessTrustProviderFactory> WithVerifiedAccessTrustProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerifiedAccessTrustProviders(combinedResult.T5, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1>(this CombinedResult<VerifiedAccessInstanceFactory, T1> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1>(this CombinedResult<T1, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3, T4>(this CombinedResult<VerifiedAccessInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, VerifiedAccessInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, T4, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, VerifiedAccessInstanceFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, T4, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VerifiedAccessInstanceFactory, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VerifiedAccessInstanceFactory, InnerVerifiedAccessInstanceVerifiedAccessLogsFactory> WithLoggingConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VerifiedAccessInstanceFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfigurations(combinedResult.T5, subFactoryAction));
}
