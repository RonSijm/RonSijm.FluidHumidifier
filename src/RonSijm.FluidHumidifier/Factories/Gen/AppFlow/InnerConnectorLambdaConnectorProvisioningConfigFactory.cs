// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorLambdaConnectorProvisioningConfigFactory(Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig>
{

    protected override Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig Create()
    {
        var lambdaConnectorProvisioningConfigResult = CreateLambdaConnectorProvisioningConfig();
        factoryAction?.Invoke(lambdaConnectorProvisioningConfigResult);

        return lambdaConnectorProvisioningConfigResult;
    }

    private Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig CreateLambdaConnectorProvisioningConfig()
    {
        var lambdaConnectorProvisioningConfigResult = new Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig();

        return lambdaConnectorProvisioningConfigResult;
    }

} // End Of Class

public static class InnerConnectorLambdaConnectorProvisioningConfigFactoryExtensions
{
}
