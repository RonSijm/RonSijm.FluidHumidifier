// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsTableWithColumnsResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource>
{

    internal InnerPrincipalPermissionsColumnWildcardFactory ColumnWildcardFactory { get; set; }

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource Create()
    {
        var tableWithColumnsResourceResult = CreateTableWithColumnsResource();
        factoryAction?.Invoke(tableWithColumnsResourceResult);

        return tableWithColumnsResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource CreateTableWithColumnsResource()
    {
        var tableWithColumnsResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource();

        return tableWithColumnsResourceResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource result)
    {
        base.CreateChildren(result);

        result.ColumnWildcard ??= ColumnWildcardFactory?.Build();
    }

} // End Of Class

public static class InnerPrincipalPermissionsTableWithColumnsResourceFactoryExtensions
{
    public static CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard(this InnerPrincipalPermissionsTableWithColumnsResourceFactory parentFactory, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null)
    {
        parentFactory.ColumnWildcardFactory = new InnerPrincipalPermissionsColumnWildcardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColumnWildcardFactory);
    }

    public static CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2, T3, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2, T3, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T3, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T3> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrincipalPermissionsTableWithColumnsResourceFactory, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPrincipalPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2, T3, T4, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<InnerPrincipalPermissionsTableWithColumnsResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2, T3, T4, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T3, T4, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T4, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPrincipalPermissionsTableWithColumnsResourceFactory, T4> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPrincipalPermissionsTableWithColumnsResourceFactory, InnerPrincipalPermissionsColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPrincipalPermissionsTableWithColumnsResourceFactory> combinedResult, Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T5, subFactoryAction));
}
