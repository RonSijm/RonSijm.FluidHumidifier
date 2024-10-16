// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerApplicationApplicationSourceConfigFactory(Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig>
{

    internal InnerApplicationExternalUrlConfigFactory ExternalUrlConfigFactory { get; set; }

    protected override Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig Create()
    {
        var applicationSourceConfigResult = CreateApplicationSourceConfig();
        factoryAction?.Invoke(applicationSourceConfigResult);

        return applicationSourceConfigResult;
    }

    private Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig CreateApplicationSourceConfig()
    {
        var applicationSourceConfigResult = new Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig();

        return applicationSourceConfigResult;
    }
    public override void CreateChildren(Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig result)
    {
        base.CreateChildren(result);

        result.ExternalUrlConfig ??= ExternalUrlConfigFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationApplicationSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerApplicationApplicationSourceConfigFactory, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig(this InnerApplicationApplicationSourceConfigFactory parentFactory, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null)
    {
        parentFactory.ExternalUrlConfigFactory = new InnerApplicationExternalUrlConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExternalUrlConfigFactory);
    }

    public static CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1>(this CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1>(this CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2>(this CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2>(this CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2>(this CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2, T3, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3>(this CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2, T3, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3>(this CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory, T3, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationSourceConfigFactory, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationSourceConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2, T3, T4, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3, T4>(this CombinedResult<InnerApplicationApplicationSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2, T3, T4, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationApplicationSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory, T3, T4, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationApplicationSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationSourceConfigFactory, T4, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationSourceConfigFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationSourceConfigFactory, InnerApplicationExternalUrlConfigFactory> WithExternalUrlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationSourceConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalUrlConfig(combinedResult.T5, subFactoryAction));
}
