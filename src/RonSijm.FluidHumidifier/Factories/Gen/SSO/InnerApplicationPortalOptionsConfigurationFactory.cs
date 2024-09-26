// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerApplicationPortalOptionsConfigurationFactory(Action<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration>
{

    internal InnerApplicationSignInOptionsFactory SignInOptionsFactory { get; set; }

    protected override Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration Create()
    {
        var portalOptionsConfigurationResult = CreatePortalOptionsConfiguration();
        factoryAction?.Invoke(portalOptionsConfigurationResult);

        return portalOptionsConfigurationResult;
    }

    private Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration CreatePortalOptionsConfiguration()
    {
        var portalOptionsConfigurationResult = new Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration();

        return portalOptionsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration result)
    {
        base.CreateChildren(result);

        result.SignInOptions ??= SignInOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationPortalOptionsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, InnerApplicationSignInOptionsFactory> WithSignInOptions(this InnerApplicationPortalOptionsConfigurationFactory parentFactory, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null)
    {
        parentFactory.SignInOptionsFactory = new InnerApplicationSignInOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SignInOptionsFactory);
    }

    public static CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1>(this CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignInOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1>(this CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignInOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2>(this CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2>(this CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2>(this CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2, T3, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3>(this CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2, T3, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3>(this CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory, T3, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory, T3> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationPortalOptionsConfigurationFactory, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationPortalOptionsConfigurationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2, T3, T4, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3, T4>(this CombinedResult<InnerApplicationPortalOptionsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2, T3, T4, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationPortalOptionsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory, T3, T4, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationPortalOptionsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationPortalOptionsConfigurationFactory, T4, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationPortalOptionsConfigurationFactory, T4> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationPortalOptionsConfigurationFactory, InnerApplicationSignInOptionsFactory> WithSignInOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationPortalOptionsConfigurationFactory> combinedResult, Action<Humidifier.SSO.ApplicationTypes.SignInOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInOptions(combinedResult.T5, subFactoryAction));
}
