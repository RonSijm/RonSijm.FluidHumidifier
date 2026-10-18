// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsTableResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource Create()
    {
        var tableResourceResult = CreateTableResource();
        factoryAction?.Invoke(tableResourceResult);

        return tableResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource CreateTableResource()
    {
        var tableResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource();

        return tableResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsTableResourceFactoryExtensions
{
}
