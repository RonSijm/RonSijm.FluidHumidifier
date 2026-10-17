// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationLibraryEncryptionConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationLibraryEncryptionConfigurationFactoryExtensions
{
}
