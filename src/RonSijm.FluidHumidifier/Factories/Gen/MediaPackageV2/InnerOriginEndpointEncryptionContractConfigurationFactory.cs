// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointEncryptionContractConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration Create()
    {
        var encryptionContractConfigurationResult = CreateEncryptionContractConfiguration();
        factoryAction?.Invoke(encryptionContractConfigurationResult);

        return encryptionContractConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration CreateEncryptionContractConfiguration()
    {
        var encryptionContractConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration();

        return encryptionContractConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointEncryptionContractConfigurationFactoryExtensions
{
}
