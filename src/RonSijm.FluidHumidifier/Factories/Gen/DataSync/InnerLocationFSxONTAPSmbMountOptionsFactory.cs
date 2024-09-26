// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxONTAPSmbMountOptionsFactory(Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions>
{

    protected override Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions Create()
    {
        var smbMountOptionsResult = CreateSmbMountOptions();
        factoryAction?.Invoke(smbMountOptionsResult);

        return smbMountOptionsResult;
    }

    private Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions CreateSmbMountOptions()
    {
        var smbMountOptionsResult = new Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions();

        return smbMountOptionsResult;
    }

} // End Of Class

public static class InnerLocationFSxONTAPSmbMountOptionsFactoryExtensions
{
}
