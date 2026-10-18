// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataLakeSettingsReadOnlyAdminsFactory(Action<Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins>
{

    protected override Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins Create()
    {
        var readOnlyAdminsResult = CreateReadOnlyAdmins();
        factoryAction?.Invoke(readOnlyAdminsResult);

        return readOnlyAdminsResult;
    }

    private Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins CreateReadOnlyAdmins()
    {
        var readOnlyAdminsResult = new Humidifier.LakeFormation.DataLakeSettingsTypes.ReadOnlyAdmins();

        return readOnlyAdminsResult;
    }

} // End Of Class

public static class InnerDataLakeSettingsReadOnlyAdminsFactoryExtensions
{
}
