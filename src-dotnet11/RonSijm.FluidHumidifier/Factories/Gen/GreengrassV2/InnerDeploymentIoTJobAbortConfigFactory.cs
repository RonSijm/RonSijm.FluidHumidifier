// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentIoTJobAbortConfigFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig>
{

    protected override Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig Create()
    {
        var ioTJobAbortConfigResult = CreateIoTJobAbortConfig();
        factoryAction?.Invoke(ioTJobAbortConfigResult);

        return ioTJobAbortConfigResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig CreateIoTJobAbortConfig()
    {
        var ioTJobAbortConfigResult = new Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig();

        return ioTJobAbortConfigResult;
    }

} // End Of Class

public static class InnerDeploymentIoTJobAbortConfigFactoryExtensions
{
}
