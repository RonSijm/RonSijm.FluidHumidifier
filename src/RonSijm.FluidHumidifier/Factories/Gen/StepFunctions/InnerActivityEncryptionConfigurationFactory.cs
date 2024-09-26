// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerActivityEncryptionConfigurationFactory(Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration>
{

    protected override Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerActivityEncryptionConfigurationFactoryExtensions
{
}
