// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationNFSOnPremConfigFactory(Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationNFSTypes.OnPremConfig>
{

    protected override Humidifier.DataSync.LocationNFSTypes.OnPremConfig Create()
    {
        var onPremConfigResult = CreateOnPremConfig();
        factoryAction?.Invoke(onPremConfigResult);

        return onPremConfigResult;
    }

    private Humidifier.DataSync.LocationNFSTypes.OnPremConfig CreateOnPremConfig()
    {
        var onPremConfigResult = new Humidifier.DataSync.LocationNFSTypes.OnPremConfig();

        return onPremConfigResult;
    }

} // End Of Class

public static class InnerLocationNFSOnPremConfigFactoryExtensions
{
}
