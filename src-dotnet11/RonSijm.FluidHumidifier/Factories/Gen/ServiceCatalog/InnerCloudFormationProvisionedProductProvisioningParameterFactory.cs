// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProvisionedProductProvisioningParameterFactory(Action<Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningParameter> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningParameter>
{

    protected override Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningParameter Create()
    {
        var provisioningParameterResult = CreateProvisioningParameter();
        factoryAction?.Invoke(provisioningParameterResult);

        return provisioningParameterResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningParameter CreateProvisioningParameter()
    {
        var provisioningParameterResult = new Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningParameter();

        return provisioningParameterResult;
    }

} // End Of Class

public static class InnerCloudFormationProvisionedProductProvisioningParameterFactoryExtensions
{
}
