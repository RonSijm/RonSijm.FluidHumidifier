// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsDataLocationResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource Create()
    {
        var dataLocationResourceResult = CreateDataLocationResource();
        factoryAction?.Invoke(dataLocationResourceResult);

        return dataLocationResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource CreateDataLocationResource()
    {
        var dataLocationResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource();

        return dataLocationResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsDataLocationResourceFactoryExtensions
{
}
