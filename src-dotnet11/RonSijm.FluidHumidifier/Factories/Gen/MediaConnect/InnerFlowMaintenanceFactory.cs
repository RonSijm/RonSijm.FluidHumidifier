// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowMaintenanceFactory(Action<Humidifier.MediaConnect.FlowTypes.Maintenance> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.Maintenance>
{

    protected override Humidifier.MediaConnect.FlowTypes.Maintenance Create()
    {
        var maintenanceResult = CreateMaintenance();
        factoryAction?.Invoke(maintenanceResult);

        return maintenanceResult;
    }

    private Humidifier.MediaConnect.FlowTypes.Maintenance CreateMaintenance()
    {
        var maintenanceResult = new Humidifier.MediaConnect.FlowTypes.Maintenance();

        return maintenanceResult;
    }

} // End Of Class

public static class InnerFlowMaintenanceFactoryExtensions
{
}
