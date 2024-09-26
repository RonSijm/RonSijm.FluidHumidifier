// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsTableResourceFactory(Action<Humidifier.LakeFormation.PermissionsTypes.TableResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.TableResource>
{

    internal InnerPermissionsTableWildcardFactory TableWildcardFactory { get; set; }

    protected override Humidifier.LakeFormation.PermissionsTypes.TableResource Create()
    {
        var tableResourceResult = CreateTableResource();
        factoryAction?.Invoke(tableResourceResult);

        return tableResourceResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.TableResource CreateTableResource()
    {
        var tableResourceResult = new Humidifier.LakeFormation.PermissionsTypes.TableResource();

        return tableResourceResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.PermissionsTypes.TableResource result)
    {
        base.CreateChildren(result);

        result.TableWildcard ??= TableWildcardFactory?.Build();
    }

} // End Of Class

public static class InnerPermissionsTableResourceFactoryExtensions
{
    public static CombinedResult<InnerPermissionsTableResourceFactory, InnerPermissionsTableWildcardFactory> WithTableWildcard(this InnerPermissionsTableResourceFactory parentFactory, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null)
    {
        parentFactory.TableWildcardFactory = new InnerPermissionsTableWildcardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TableWildcardFactory);
    }

    public static CombinedResult<InnerPermissionsTableResourceFactory, T1, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1>(this CombinedResult<InnerPermissionsTableResourceFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableResourceFactory, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1>(this CombinedResult<T1, InnerPermissionsTableResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableResourceFactory, T1, T2, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2>(this CombinedResult<InnerPermissionsTableResourceFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableResourceFactory, T2, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2>(this CombinedResult<T1, InnerPermissionsTableResourceFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableResourceFactory, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2>(this CombinedResult<T1, T2, InnerPermissionsTableResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableResourceFactory, T1, T2, T3, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3>(this CombinedResult<InnerPermissionsTableResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableResourceFactory, T2, T3, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3>(this CombinedResult<T1, InnerPermissionsTableResourceFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableResourceFactory, T3, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3>(this CombinedResult<T1, T2, InnerPermissionsTableResourceFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionsTableResourceFactory, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPermissionsTableResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableResourceFactory, T1, T2, T3, T4, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3, T4>(this CombinedResult<InnerPermissionsTableResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableResourceFactory, T2, T3, T4, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3, T4>(this CombinedResult<T1, InnerPermissionsTableResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableResourceFactory, T3, T4, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPermissionsTableResourceFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionsTableResourceFactory, T4, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPermissionsTableResourceFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPermissionsTableResourceFactory, InnerPermissionsTableWildcardFactory> WithTableWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPermissionsTableResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableWildcard(combinedResult.T5, subFactoryAction));
}
