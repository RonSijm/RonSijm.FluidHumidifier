// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointEncryptionContractConfigurationFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration>
{

    protected override Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration Create()
    {
        var encryptionContractConfigurationResult = CreateEncryptionContractConfiguration();
        factoryAction?.Invoke(encryptionContractConfigurationResult);

        return encryptionContractConfigurationResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration CreateEncryptionContractConfiguration()
    {
        var encryptionContractConfigurationResult = new Humidifier.MediaPackage.OriginEndpointTypes.EncryptionContractConfiguration();

        return encryptionContractConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointEncryptionContractConfigurationFactoryExtensions
{
}
