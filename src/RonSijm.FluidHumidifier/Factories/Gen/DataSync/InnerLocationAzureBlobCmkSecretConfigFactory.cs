// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationAzureBlobCmkSecretConfigFactory(Action<Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig>
{

    protected override Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig Create()
    {
        var cmkSecretConfigResult = CreateCmkSecretConfig();
        factoryAction?.Invoke(cmkSecretConfigResult);

        return cmkSecretConfigResult;
    }

    private Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig CreateCmkSecretConfig()
    {
        var cmkSecretConfigResult = new Humidifier.DataSync.LocationAzureBlobTypes.CmkSecretConfig();

        return cmkSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationAzureBlobCmkSecretConfigFactoryExtensions
{
}
