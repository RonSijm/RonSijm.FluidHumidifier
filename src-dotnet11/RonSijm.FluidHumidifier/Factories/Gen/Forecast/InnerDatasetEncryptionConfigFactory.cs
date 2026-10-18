// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Forecast;

public class InnerDatasetEncryptionConfigFactory(Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Forecast.DatasetTypes.EncryptionConfig>
{

    protected override Humidifier.Forecast.DatasetTypes.EncryptionConfig Create()
    {
        var encryptionConfigResult = CreateEncryptionConfig();
        factoryAction?.Invoke(encryptionConfigResult);

        return encryptionConfigResult;
    }

    private Humidifier.Forecast.DatasetTypes.EncryptionConfig CreateEncryptionConfig()
    {
        var encryptionConfigResult = new Humidifier.Forecast.DatasetTypes.EncryptionConfig();

        return encryptionConfigResult;
    }

} // End Of Class

public static class InnerDatasetEncryptionConfigFactoryExtensions
{
}
