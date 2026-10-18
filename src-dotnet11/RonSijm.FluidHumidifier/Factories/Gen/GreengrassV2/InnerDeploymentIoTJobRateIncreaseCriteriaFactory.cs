// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentIoTJobRateIncreaseCriteriaFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria>
{

    protected override Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria Create()
    {
        var ioTJobRateIncreaseCriteriaResult = CreateIoTJobRateIncreaseCriteria();
        factoryAction?.Invoke(ioTJobRateIncreaseCriteriaResult);

        return ioTJobRateIncreaseCriteriaResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria CreateIoTJobRateIncreaseCriteria()
    {
        var ioTJobRateIncreaseCriteriaResult = new Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria();

        return ioTJobRateIncreaseCriteriaResult;
    }

} // End Of Class

public static class InnerDeploymentIoTJobRateIncreaseCriteriaFactoryExtensions
{
}
