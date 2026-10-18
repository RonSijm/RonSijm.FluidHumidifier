// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerMaintenanceWindowFactory(Action<Humidifier.AmazonMQ.BrokerTypes.MaintenanceWindow> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.MaintenanceWindow>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.AmazonMQ.BrokerTypes.MaintenanceWindow();

        return maintenanceWindowResult;
    }

} // End Of Class

public static class InnerBrokerMaintenanceWindowFactoryExtensions
{
}
