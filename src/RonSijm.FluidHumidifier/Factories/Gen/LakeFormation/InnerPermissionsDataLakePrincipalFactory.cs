// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsDataLakePrincipalFactory(Action<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal>
{

    protected override Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal Create()
    {
        var dataLakePrincipalResult = CreateDataLakePrincipal();
        factoryAction?.Invoke(dataLakePrincipalResult);

        return dataLakePrincipalResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal CreateDataLakePrincipal()
    {
        var dataLakePrincipalResult = new Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal();

        return dataLakePrincipalResult;
    }

} // End Of Class

public static class InnerPermissionsDataLakePrincipalFactoryExtensions
{
}
