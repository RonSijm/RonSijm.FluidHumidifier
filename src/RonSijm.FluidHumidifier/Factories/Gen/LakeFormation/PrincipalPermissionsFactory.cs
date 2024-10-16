// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class PrincipalPermissionsFactory(string resourceName = null, Action<Humidifier.LakeFormation.PrincipalPermissions> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.PrincipalPermissions>(resourceName)
{

    internal InnerPrincipalPermissionsResourceFactory ResourceFactory { get; set; }

    internal InnerPrincipalPermissionsDataLakePrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.LakeFormation.PrincipalPermissions Create()
    {
        var principalPermissionsResult = CreatePrincipalPermissions();
        factoryAction?.Invoke(principalPermissionsResult);

        return principalPermissionsResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissions CreatePrincipalPermissions()
    {
        var principalPermissionsResult = new Humidifier.LakeFormation.PrincipalPermissions
        {
            GivenName = InputResourceName,
        };

        return principalPermissionsResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.PrincipalPermissions result)
    {
        base.CreateChildren(result);

        result.Resource ??= ResourceFactory?.Build();
        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class PrincipalPermissionsFactoryExtensions
{
    public static CombinedResult<PrincipalPermissionsFactory, InnerPrincipalPermissionsResourceFactory> WithResource(this PrincipalPermissionsFactory parentFactory, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null)
    {
        parentFactory.ResourceFactory = new InnerPrincipalPermissionsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceFactory);
    }

    public static CombinedResult<PrincipalPermissionsFactory, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal(this PrincipalPermissionsFactory parentFactory, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerPrincipalPermissionsDataLakePrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<PrincipalPermissionsFactory, T1, InnerPrincipalPermissionsResourceFactory> WithResource<T1>(this CombinedResult<PrincipalPermissionsFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, InnerPrincipalPermissionsResourceFactory> WithResource<T1>(this CombinedResult<T1, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<PrincipalPermissionsFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, PrincipalPermissionsFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, T2, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<PrincipalPermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, PrincipalPermissionsFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, PrincipalPermissionsFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, T4, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, T4, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, T4, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, T4, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PrincipalPermissionsFactory, InnerPrincipalPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1>(this CombinedResult<PrincipalPermissionsFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<PrincipalPermissionsFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, PrincipalPermissionsFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<PrincipalPermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, PrincipalPermissionsFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, PrincipalPermissionsFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, T4, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<PrincipalPermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, T4, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, PrincipalPermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, T4, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrincipalPermissionsFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, T4, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrincipalPermissionsFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PrincipalPermissionsFactory, InnerPrincipalPermissionsDataLakePrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrincipalPermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction));
}
