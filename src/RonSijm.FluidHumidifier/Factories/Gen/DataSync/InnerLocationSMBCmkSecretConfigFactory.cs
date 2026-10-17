// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationSMBCmkSecretConfigFactory(Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig>
{

    protected override Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig Create()
    {
        var cmkSecretConfigResult = CreateCmkSecretConfig();
        factoryAction?.Invoke(cmkSecretConfigResult);

        return cmkSecretConfigResult;
    }

    private Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig CreateCmkSecretConfig()
    {
        var cmkSecretConfigResult = new Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig();

        return cmkSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationSMBCmkSecretConfigFactoryExtensions
{
}
