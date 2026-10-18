// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class InnerAccessPointCreationPermissionsFactory(Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> factoryAction = null) : SubResourceFactory<Humidifier.S3Files.AccessPointTypes.CreationPermissions>
{

    protected override Humidifier.S3Files.AccessPointTypes.CreationPermissions Create()
    {
        var creationPermissionsResult = CreateCreationPermissions();
        factoryAction?.Invoke(creationPermissionsResult);

        return creationPermissionsResult;
    }

    private Humidifier.S3Files.AccessPointTypes.CreationPermissions CreateCreationPermissions()
    {
        var creationPermissionsResult = new Humidifier.S3Files.AccessPointTypes.CreationPermissions();

        return creationPermissionsResult;
    }

} // End Of Class

public static class InnerAccessPointCreationPermissionsFactoryExtensions
{
}
