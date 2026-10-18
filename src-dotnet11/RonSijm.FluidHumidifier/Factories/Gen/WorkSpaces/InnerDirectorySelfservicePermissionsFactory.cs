// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectorySelfservicePermissionsFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions Create()
    {
        var selfservicePermissionsResult = CreateSelfservicePermissions();
        factoryAction?.Invoke(selfservicePermissionsResult);

        return selfservicePermissionsResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions CreateSelfservicePermissions()
    {
        var selfservicePermissionsResult = new Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions();

        return selfservicePermissionsResult;
    }

} // End Of Class

public static class InnerDirectorySelfservicePermissionsFactoryExtensions
{
}
