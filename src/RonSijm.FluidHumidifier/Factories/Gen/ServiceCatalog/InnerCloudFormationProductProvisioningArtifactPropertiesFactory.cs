// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductProvisioningArtifactPropertiesFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties>
{

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties Create()
    {
        var provisioningArtifactPropertiesResult = CreateProvisioningArtifactProperties();
        factoryAction?.Invoke(provisioningArtifactPropertiesResult);

        return provisioningArtifactPropertiesResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties CreateProvisioningArtifactProperties()
    {
        var provisioningArtifactPropertiesResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties();

        return provisioningArtifactPropertiesResult;
    }

} // End Of Class

public static class InnerCloudFormationProductProvisioningArtifactPropertiesFactoryExtensions
{
}
