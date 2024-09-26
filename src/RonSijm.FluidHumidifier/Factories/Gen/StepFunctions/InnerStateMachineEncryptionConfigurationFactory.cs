// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineEncryptionConfigurationFactory(Action<Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration>
{

    protected override Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerStateMachineEncryptionConfigurationFactoryExtensions
{
}
