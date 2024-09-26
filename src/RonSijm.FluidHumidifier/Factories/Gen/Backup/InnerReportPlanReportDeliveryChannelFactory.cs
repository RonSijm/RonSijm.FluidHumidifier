// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerReportPlanReportDeliveryChannelFactory(Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> factoryAction = null) : SubResourceFactory<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel>
{

    protected override Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel Create()
    {
        var reportDeliveryChannelResult = CreateReportDeliveryChannel();
        factoryAction?.Invoke(reportDeliveryChannelResult);

        return reportDeliveryChannelResult;
    }

    private Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel CreateReportDeliveryChannel()
    {
        var reportDeliveryChannelResult = new Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel();

        return reportDeliveryChannelResult;
    }

} // End Of Class

public static class InnerReportPlanReportDeliveryChannelFactoryExtensions
{
}
