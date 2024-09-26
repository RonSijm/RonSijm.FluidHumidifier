// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxONTAPNfsMountOptionsFactory(Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions>
{

    protected override Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions Create()
    {
        var nfsMountOptionsResult = CreateNfsMountOptions();
        factoryAction?.Invoke(nfsMountOptionsResult);

        return nfsMountOptionsResult;
    }

    private Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions CreateNfsMountOptions()
    {
        var nfsMountOptionsResult = new Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions();

        return nfsMountOptionsResult;
    }

} // End Of Class

public static class InnerLocationFSxONTAPNfsMountOptionsFactoryExtensions
{
}
