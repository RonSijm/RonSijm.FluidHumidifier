// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerApplicationIdentitySourceFactory(Action<Humidifier.AccountAccess.ApplicationTypes.IdentitySource> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.ApplicationTypes.IdentitySource>
{

    internal InnerApplicationIdentityCenterFactory IdentityCenterFactory { get; set; }

    protected override Humidifier.AccountAccess.ApplicationTypes.IdentitySource Create()
    {
        var identitySourceResult = CreateIdentitySource();
        factoryAction?.Invoke(identitySourceResult);

        return identitySourceResult;
    }

    private Humidifier.AccountAccess.ApplicationTypes.IdentitySource CreateIdentitySource()
    {
        var identitySourceResult = new Humidifier.AccountAccess.ApplicationTypes.IdentitySource();

        return identitySourceResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.ApplicationTypes.IdentitySource result)
    {
        base.CreateChildren(result);

        result.IdentityCenter ??= IdentityCenterFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationIdentitySourceFactoryExtensions
{
    public static CombinedResult<InnerApplicationIdentitySourceFactory, InnerApplicationIdentityCenterFactory> WithIdentityCenter(this InnerApplicationIdentitySourceFactory parentFactory, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null)
    {
        parentFactory.IdentityCenterFactory = new InnerApplicationIdentityCenterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityCenterFactory);
    }

    public static CombinedResult<InnerApplicationIdentitySourceFactory, T1, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1>(this CombinedResult<InnerApplicationIdentitySourceFactory, T1> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationIdentitySourceFactory, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1>(this CombinedResult<T1, InnerApplicationIdentitySourceFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2>(this CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2>(this CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2>(this CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2, T3, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2, T3, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory, T3, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory, T3> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationIdentitySourceFactory, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationIdentitySourceFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2, T3, T4, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<InnerApplicationIdentitySourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2, T3, T4, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationIdentitySourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory, T3, T4, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationIdentitySourceFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationIdentitySourceFactory, T4, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationIdentitySourceFactory, T4> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationIdentitySourceFactory, InnerApplicationIdentityCenterFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationIdentitySourceFactory> combinedResult, Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T5, subFactoryAction).T2);
}
