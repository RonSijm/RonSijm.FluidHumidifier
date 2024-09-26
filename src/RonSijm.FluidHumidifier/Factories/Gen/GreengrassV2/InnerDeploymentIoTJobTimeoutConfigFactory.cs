// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentIoTJobTimeoutConfigFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig>
{

    protected override Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig Create()
    {
        var ioTJobTimeoutConfigResult = CreateIoTJobTimeoutConfig();
        factoryAction?.Invoke(ioTJobTimeoutConfigResult);

        return ioTJobTimeoutConfigResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig CreateIoTJobTimeoutConfig()
    {
        var ioTJobTimeoutConfigResult = new Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig();

        return ioTJobTimeoutConfigResult;
    }

} // End Of Class

public static class InnerDeploymentIoTJobTimeoutConfigFactoryExtensions
{
}
