// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsDataLakePrincipalFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal Create()
    {
        var dataLakePrincipalResult = CreateDataLakePrincipal();
        factoryAction?.Invoke(dataLakePrincipalResult);

        return dataLakePrincipalResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal CreateDataLakePrincipal()
    {
        var dataLakePrincipalResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal();

        return dataLakePrincipalResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsDataLakePrincipalFactoryExtensions
{
}
