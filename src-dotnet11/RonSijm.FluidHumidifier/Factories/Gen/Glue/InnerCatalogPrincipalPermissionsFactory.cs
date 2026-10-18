// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogPrincipalPermissionsFactory(Action<Humidifier.Glue.CatalogTypes.PrincipalPermissions> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.PrincipalPermissions>
{

    internal InnerCatalogDataLakePrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.Glue.CatalogTypes.PrincipalPermissions Create()
    {
        var principalPermissionsResult = CreatePrincipalPermissions();
        factoryAction?.Invoke(principalPermissionsResult);

        return principalPermissionsResult;
    }

    private Humidifier.Glue.CatalogTypes.PrincipalPermissions CreatePrincipalPermissions()
    {
        var principalPermissionsResult = new Humidifier.Glue.CatalogTypes.PrincipalPermissions();

        return principalPermissionsResult;
    }
    public override void CreateChildren(Humidifier.Glue.CatalogTypes.PrincipalPermissions result)
    {
        base.CreateChildren(result);

        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class InnerCatalogPrincipalPermissionsFactoryExtensions
{
    public static CombinedResult<InnerCatalogPrincipalPermissionsFactory, InnerCatalogDataLakePrincipalFactory> WithPrincipal(this InnerCatalogPrincipalPermissionsFactory parentFactory, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerCatalogDataLakePrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1>(this CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2, T3, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2, T3, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory, T3, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCatalogPrincipalPermissionsFactory, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCatalogPrincipalPermissionsFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2, T3, T4, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<InnerCatalogPrincipalPermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2, T3, T4, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, InnerCatalogPrincipalPermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory, T3, T4, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCatalogPrincipalPermissionsFactory, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCatalogPrincipalPermissionsFactory, T4, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCatalogPrincipalPermissionsFactory, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCatalogPrincipalPermissionsFactory, InnerCatalogDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCatalogPrincipalPermissionsFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction).T2);
}
