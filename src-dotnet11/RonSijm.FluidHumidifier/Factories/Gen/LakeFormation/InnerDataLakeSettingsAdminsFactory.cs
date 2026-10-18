// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataLakeSettingsAdminsFactory(Action<Humidifier.LakeFormation.DataLakeSettingsTypes.Admins> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataLakeSettingsTypes.Admins>
{

    protected override Humidifier.LakeFormation.DataLakeSettingsTypes.Admins Create()
    {
        var adminsResult = CreateAdmins();
        factoryAction?.Invoke(adminsResult);

        return adminsResult;
    }

    private Humidifier.LakeFormation.DataLakeSettingsTypes.Admins CreateAdmins()
    {
        var adminsResult = new Humidifier.LakeFormation.DataLakeSettingsTypes.Admins();

        return adminsResult;
    }

} // End Of Class

public static class InnerDataLakeSettingsAdminsFactoryExtensions
{
}
