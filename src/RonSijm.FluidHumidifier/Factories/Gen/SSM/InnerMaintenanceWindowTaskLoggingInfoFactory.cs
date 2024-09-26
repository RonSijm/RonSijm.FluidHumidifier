// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskLoggingInfoFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo Create()
    {
        var loggingInfoResult = CreateLoggingInfo();
        factoryAction?.Invoke(loggingInfoResult);

        return loggingInfoResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo CreateLoggingInfo()
    {
        var loggingInfoResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.LoggingInfo();

        return loggingInfoResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskLoggingInfoFactoryExtensions
{
}
