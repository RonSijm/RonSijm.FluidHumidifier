// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleVpcConfigFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleVpcConfigFactoryExtensions
{
}
