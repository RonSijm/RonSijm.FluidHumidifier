// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxWindowsCmkSecretConfigFactory(Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig>
{

    protected override Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig Create()
    {
        var cmkSecretConfigResult = CreateCmkSecretConfig();
        factoryAction?.Invoke(cmkSecretConfigResult);

        return cmkSecretConfigResult;
    }

    private Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig CreateCmkSecretConfig()
    {
        var cmkSecretConfigResult = new Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig();

        return cmkSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationFSxWindowsCmkSecretConfigFactoryExtensions
{
}
