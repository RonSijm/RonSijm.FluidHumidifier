// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsColumnWildcardFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard Create()
    {
        var columnWildcardResult = CreateColumnWildcard();
        factoryAction?.Invoke(columnWildcardResult);

        return columnWildcardResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard CreateColumnWildcard()
    {
        var columnWildcardResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard();

        return columnWildcardResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsColumnWildcardFactoryExtensions
{
}
