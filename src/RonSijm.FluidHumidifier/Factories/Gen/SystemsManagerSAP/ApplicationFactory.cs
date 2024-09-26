// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SystemsManagerSAP;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.SystemsManagerSAP.Application> factoryAction = null) : ResourceFactory<Humidifier.SystemsManagerSAP.Application>(resourceName)
{

    internal List<InnerApplicationCredentialFactory> CredentialsFactories { get; set; } = [];

    protected override Humidifier.SystemsManagerSAP.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.SystemsManagerSAP.Application CreateApplication()
    {
        var applicationResult = new Humidifier.SystemsManagerSAP.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.SystemsManagerSAP.Application result)
    {
        base.CreateChildren(result);

        result.Credentials = CredentialsFactories.Any() ? CredentialsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationCredentialFactory> WithCredentials(this ApplicationFactory parentFactory, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null)
    {
        var factory = new InnerApplicationCredentialFactory(subFactoryAction);
        parentFactory.CredentialsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationFactory, T1, InnerApplicationCredentialFactory> WithCredentials<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationCredentialFactory> WithCredentials<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationCredentialFactory> WithCredentials<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationCredentialFactory> WithCredentials<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationCredentialFactory> WithCredentials<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationCredentialFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T5, subFactoryAction));
}
