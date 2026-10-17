// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.AccountAccess.Application> factoryAction = null) : ResourceFactory<Humidifier.AccountAccess.Application>(resourceName)
{

    internal InnerApplicationIdentitySourceFactory IdentitySourceFactory { get; set; }

    protected override Humidifier.AccountAccess.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.AccountAccess.Application CreateApplication()
    {
        var applicationResult = new Humidifier.AccountAccess.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.Application result)
    {
        base.CreateChildren(result);

        result.IdentitySource ??= IdentitySourceFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationIdentitySourceFactory> WithIdentitySource(this ApplicationFactory parentFactory, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null)
    {
        parentFactory.IdentitySourceFactory = new InnerApplicationIdentitySourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentitySourceFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentitySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentitySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationIdentitySourceFactory> WithIdentitySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySource(combinedResult.T5, subFactoryAction).T2);
}
