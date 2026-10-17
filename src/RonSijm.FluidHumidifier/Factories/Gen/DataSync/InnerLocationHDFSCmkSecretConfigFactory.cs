// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationHDFSCmkSecretConfigFactory(Action<Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig>
{

    protected override Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig Create()
    {
        var cmkSecretConfigResult = CreateCmkSecretConfig();
        factoryAction?.Invoke(cmkSecretConfigResult);

        return cmkSecretConfigResult;
    }

    private Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig CreateCmkSecretConfig()
    {
        var cmkSecretConfigResult = new Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig();

        return cmkSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationHDFSCmkSecretConfigFactoryExtensions
{
}
