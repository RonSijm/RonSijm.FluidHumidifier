// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationObjectStorageCmkSecretConfigFactory(Action<Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig>
{

    protected override Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig Create()
    {
        var cmkSecretConfigResult = CreateCmkSecretConfig();
        factoryAction?.Invoke(cmkSecretConfigResult);

        return cmkSecretConfigResult;
    }

    private Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig CreateCmkSecretConfig()
    {
        var cmkSecretConfigResult = new Humidifier.DataSync.LocationObjectStorageTypes.CmkSecretConfig();

        return cmkSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationObjectStorageCmkSecretConfigFactoryExtensions
{
}
