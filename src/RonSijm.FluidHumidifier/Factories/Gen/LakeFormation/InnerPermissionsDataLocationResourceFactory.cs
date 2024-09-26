// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsDataLocationResourceFactory(Action<Humidifier.LakeFormation.PermissionsTypes.DataLocationResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.DataLocationResource>
{

    protected override Humidifier.LakeFormation.PermissionsTypes.DataLocationResource Create()
    {
        var dataLocationResourceResult = CreateDataLocationResource();
        factoryAction?.Invoke(dataLocationResourceResult);

        return dataLocationResourceResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.DataLocationResource CreateDataLocationResource()
    {
        var dataLocationResourceResult = new Humidifier.LakeFormation.PermissionsTypes.DataLocationResource();

        return dataLocationResourceResult;
    }

} // End Of Class

public static class InnerPermissionsDataLocationResourceFactoryExtensions
{
}
