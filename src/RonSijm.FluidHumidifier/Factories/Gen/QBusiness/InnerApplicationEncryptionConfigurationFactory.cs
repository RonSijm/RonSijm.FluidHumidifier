// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationEncryptionConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationEncryptionConfigurationFactoryExtensions
{
}
