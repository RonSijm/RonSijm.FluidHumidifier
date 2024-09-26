// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataLakeSettingsCreateTableDefaultPermissionsFactory(Action<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions>
{

    protected override Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions Create()
    {
        var createTableDefaultPermissionsResult = CreateCreateTableDefaultPermissions();
        factoryAction?.Invoke(createTableDefaultPermissionsResult);

        return createTableDefaultPermissionsResult;
    }

    private Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions CreateCreateTableDefaultPermissions()
    {
        var createTableDefaultPermissionsResult = new Humidifier.LakeFormation.DataLakeSettingsTypes.CreateTableDefaultPermissions();

        return createTableDefaultPermissionsResult;
    }

} // End Of Class

public static class InnerDataLakeSettingsCreateTableDefaultPermissionsFactoryExtensions
{
}
