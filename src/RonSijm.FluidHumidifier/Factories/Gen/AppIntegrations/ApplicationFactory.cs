// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.AppIntegrations.Application> factoryAction = null) : ResourceFactory<Humidifier.AppIntegrations.Application>(resourceName)
{

    internal InnerApplicationApplicationSourceConfigFactory ApplicationSourceConfigFactory { get; set; }

    protected override Humidifier.AppIntegrations.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.AppIntegrations.Application CreateApplication()
    {
        var applicationResult = new Humidifier.AppIntegrations.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.AppIntegrations.Application result)
    {
        base.CreateChildren(result);

        result.ApplicationSourceConfig ??= ApplicationSourceConfigFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig(this ApplicationFactory parentFactory, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null)
    {
        parentFactory.ApplicationSourceConfigFactory = new InnerApplicationApplicationSourceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationSourceConfigFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationApplicationSourceConfigFactory> WithApplicationSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSourceConfig(combinedResult.T5, subFactoryAction));
}
