// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsColumnWildcardFactory(Action<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard>
{

    protected override Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard Create()
    {
        var columnWildcardResult = CreateColumnWildcard();
        factoryAction?.Invoke(columnWildcardResult);

        return columnWildcardResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard CreateColumnWildcard()
    {
        var columnWildcardResult = new Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard();

        return columnWildcardResult;
    }

} // End Of Class

public static class InnerPermissionsColumnWildcardFactoryExtensions
{
}
