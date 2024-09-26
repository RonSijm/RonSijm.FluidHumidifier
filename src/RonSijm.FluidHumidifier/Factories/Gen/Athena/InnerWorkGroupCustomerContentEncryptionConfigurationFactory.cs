// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupCustomerContentEncryptionConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration Create()
    {
        var customerContentEncryptionConfigurationResult = CreateCustomerContentEncryptionConfiguration();
        factoryAction?.Invoke(customerContentEncryptionConfigurationResult);

        return customerContentEncryptionConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration CreateCustomerContentEncryptionConfiguration()
    {
        var customerContentEncryptionConfigurationResult = new Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration();

        return customerContentEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupCustomerContentEncryptionConfigurationFactoryExtensions
{
}
