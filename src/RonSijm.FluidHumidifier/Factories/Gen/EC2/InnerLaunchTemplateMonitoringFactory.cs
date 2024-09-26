// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateMonitoringFactory(Action<Humidifier.EC2.LaunchTemplateTypes.Monitoring> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.Monitoring>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.Monitoring Create()
    {
        var monitoringResult = CreateMonitoring();
        factoryAction?.Invoke(monitoringResult);

        return monitoringResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.Monitoring CreateMonitoring()
    {
        var monitoringResult = new Humidifier.EC2.LaunchTemplateTypes.Monitoring();

        return monitoringResult;
    }

} // End Of Class

public static class InnerLaunchTemplateMonitoringFactoryExtensions
{
}
