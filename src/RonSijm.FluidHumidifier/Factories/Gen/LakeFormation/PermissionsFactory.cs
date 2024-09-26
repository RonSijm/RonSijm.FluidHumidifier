// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class PermissionsFactory(string resourceName = null, Action<Humidifier.LakeFormation.Permissions> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.Permissions>(resourceName)
{

    internal InnerPermissionsDataLakePrincipalFactory DataLakePrincipalFactory { get; set; }

    internal InnerPermissionsResourceFactory ResourceFactory { get; set; }

    protected override Humidifier.LakeFormation.Permissions Create()
    {
        var permissionsResult = CreatePermissions();
        factoryAction?.Invoke(permissionsResult);

        return permissionsResult;
    }

    private Humidifier.LakeFormation.Permissions CreatePermissions()
    {
        var permissionsResult = new Humidifier.LakeFormation.Permissions
        {
            GivenName = InputResourceName,
        };

        return permissionsResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.Permissions result)
    {
        base.CreateChildren(result);

        result.DataLakePrincipal ??= DataLakePrincipalFactory?.Build();
        result.Resource ??= ResourceFactory?.Build();
    }

} // End Of Class

public static class PermissionsFactoryExtensions
{
    public static CombinedResult<PermissionsFactory, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal(this PermissionsFactory parentFactory, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null)
    {
        parentFactory.DataLakePrincipalFactory = new InnerPermissionsDataLakePrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataLakePrincipalFactory);
    }

    public static CombinedResult<PermissionsFactory, InnerPermissionsResourceFactory> WithResource(this PermissionsFactory parentFactory, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null)
    {
        parentFactory.ResourceFactory = new InnerPermissionsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceFactory);
    }

    public static CombinedResult<PermissionsFactory, T1, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1>(this CombinedResult<PermissionsFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1>(this CombinedResult<T1, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2>(this CombinedResult<PermissionsFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2>(this CombinedResult<T1, PermissionsFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2>(this CombinedResult<T1, T2, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, T3, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3>(this CombinedResult<PermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, T3, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3>(this CombinedResult<T1, PermissionsFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, T3, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3>(this CombinedResult<T1, T2, PermissionsFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionsFactory, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, T3, T4, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3, T4>(this CombinedResult<PermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, T3, T4, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3, T4>(this CombinedResult<T1, PermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, T3, T4, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, PermissionsFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionsFactory, T4, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PermissionsFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PermissionsFactory, InnerPermissionsDataLakePrincipalFactory> WithDataLakePrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakePrincipal(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, InnerPermissionsResourceFactory> WithResource<T1>(this CombinedResult<PermissionsFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, InnerPermissionsResourceFactory> WithResource<T1>(this CombinedResult<T1, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, InnerPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<PermissionsFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, InnerPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, PermissionsFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, InnerPermissionsResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, T2, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, T3, InnerPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<PermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, T3, InnerPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, PermissionsFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, T3, InnerPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, PermissionsFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionsFactory, InnerPermissionsResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PermissionsFactory, T1, T2, T3, T4, InnerPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<PermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionsFactory, T2, T3, T4, InnerPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, PermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionsFactory, T3, T4, InnerPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, PermissionsFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionsFactory, T4, InnerPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PermissionsFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PermissionsFactory, InnerPermissionsResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PermissionsFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T5, subFactoryAction));
}
