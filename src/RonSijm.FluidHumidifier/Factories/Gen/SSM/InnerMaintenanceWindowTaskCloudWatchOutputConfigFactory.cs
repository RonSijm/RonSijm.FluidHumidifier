// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskCloudWatchOutputConfigFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig Create()
    {
        var cloudWatchOutputConfigResult = CreateCloudWatchOutputConfig();
        factoryAction?.Invoke(cloudWatchOutputConfigResult);

        return cloudWatchOutputConfigResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig CreateCloudWatchOutputConfig()
    {
        var cloudWatchOutputConfigResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.CloudWatchOutputConfig();

        return cloudWatchOutputConfigResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskCloudWatchOutputConfigFactoryExtensions
{
}
