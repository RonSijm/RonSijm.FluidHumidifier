// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.SSO.Application> factoryAction = null) : ResourceFactory<Humidifier.SSO.Application>(resourceName)
{

    internal InnerApplicationPortalOptionsConfigurationFactory PortalOptionsFactory { get; set; }

    protected override Humidifier.SSO.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.SSO.Application CreateApplication()
    {
        var applicationResult = new Humidifier.SSO.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.SSO.Application result)
    {
        base.CreateChildren(result);

        result.PortalOptions ??= PortalOptionsFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions(this ApplicationFactory parentFactory, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null)
    {
        parentFactory.PortalOptionsFactory = new InnerApplicationPortalOptionsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortalOptionsFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationPortalOptionsConfigurationFactory> WithPortalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortalOptions(combinedResult.T5, subFactoryAction));
}
