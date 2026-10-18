// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsTableWildcardFactory(Action<Humidifier.LakeFormation.PermissionsTypes.TableWildcard> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.TableWildcard>
{

    protected override Humidifier.LakeFormation.PermissionsTypes.TableWildcard Create()
    {
        var tableWildcardResult = CreateTableWildcard();
        factoryAction?.Invoke(tableWildcardResult);

        return tableWildcardResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.TableWildcard CreateTableWildcard()
    {
        var tableWildcardResult = new Humidifier.LakeFormation.PermissionsTypes.TableWildcard();

        return tableWildcardResult;
    }

} // End Of Class

public static class InnerPermissionsTableWildcardFactoryExtensions
{
}
