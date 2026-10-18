// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateMaintenanceOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions Create()
    {
        var maintenanceOptionsResult = CreateMaintenanceOptions();
        factoryAction?.Invoke(maintenanceOptionsResult);

        return maintenanceOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions CreateMaintenanceOptions()
    {
        var maintenanceOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions();

        return maintenanceOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateMaintenanceOptionsFactoryExtensions
{
}
