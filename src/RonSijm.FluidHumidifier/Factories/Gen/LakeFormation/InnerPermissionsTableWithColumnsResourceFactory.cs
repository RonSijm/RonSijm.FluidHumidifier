// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsTableWithColumnsResourceFactory(Action<Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource>
{

    internal InnerPermissionsColumnWildcardFactory ColumnWildcardFactory { get; set; }

    protected override Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource Create()
    {
        var tableWithColumnsResourceResult = CreateTableWithColumnsResource();
        factoryAction?.Invoke(tableWithColumnsResourceResult);

        return tableWithColumnsResourceResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource CreateTableWithColumnsResource()
    {
        var tableWithColumnsResourceResult = new Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource();

        return tableWithColumnsResourceResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource result)
    {
        base.CreateChildren(result);

        result.ColumnWildcard ??= ColumnWildcardFactory?.Build();
    }

} // End Of Class

public static class InnerPermissionsTableWithColumnsResourceFactoryExtensions
{
    public static CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, InnerPermissionsColumnWildcardFactory> WithColumnWildcard(this InnerPermissionsTableWithColumnsResourceFactory parentFactory, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null)
    {
        parentFactory.ColumnWildcardFactory = new InnerPermissionsColumnWildcardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColumnWildcardFactory);
    }

    public static CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2, T3, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2, T3, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory, T3, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionsTableWithColumnsResourceFactory, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2, T3, T4, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<InnerPermissionsTableWithColumnsResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2, T3, T4, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, InnerPermissionsTableWithColumnsResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory, T3, T4, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPermissionsTableWithColumnsResourceFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionsTableWithColumnsResourceFactory, T4, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPermissionsTableWithColumnsResourceFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPermissionsTableWithColumnsResourceFactory, InnerPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T5, subFactoryAction));
}
