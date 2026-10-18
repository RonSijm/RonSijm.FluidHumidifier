// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowEncryptionConfigurationFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration>
{

    protected override Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.MWAAServerless.WorkflowTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerWorkflowEncryptionConfigurationFactoryExtensions
{
}
