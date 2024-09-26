// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class ReportPlanFactory(string resourceName = null, Action<Humidifier.Backup.ReportPlan> factoryAction = null) : ResourceFactory<Humidifier.Backup.ReportPlan>(resourceName)
{

    internal InnerReportPlanReportSettingFactory ReportSettingFactory { get; set; }

    internal InnerReportPlanReportDeliveryChannelFactory ReportDeliveryChannelFactory { get; set; }

    protected override Humidifier.Backup.ReportPlan Create()
    {
        var reportPlanResult = CreateReportPlan();
        factoryAction?.Invoke(reportPlanResult);

        return reportPlanResult;
    }

    private Humidifier.Backup.ReportPlan CreateReportPlan()
    {
        var reportPlanResult = new Humidifier.Backup.ReportPlan
        {
            GivenName = InputResourceName,
        };

        return reportPlanResult;
    }
    public override void CreateChildren(Humidifier.Backup.ReportPlan result)
    {
        base.CreateChildren(result);

        result.ReportSetting ??= ReportSettingFactory?.Build();
        result.ReportDeliveryChannel ??= ReportDeliveryChannelFactory?.Build();
    }

} // End Of Class

public static class ReportPlanFactoryExtensions
{
    public static CombinedResult<ReportPlanFactory, InnerReportPlanReportSettingFactory> WithReportSetting(this ReportPlanFactory parentFactory, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null)
    {
        parentFactory.ReportSettingFactory = new InnerReportPlanReportSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportSettingFactory);
    }

    public static CombinedResult<ReportPlanFactory, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel(this ReportPlanFactory parentFactory, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null)
    {
        parentFactory.ReportDeliveryChannelFactory = new InnerReportPlanReportDeliveryChannelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportDeliveryChannelFactory);
    }

    public static CombinedResult<ReportPlanFactory, T1, InnerReportPlanReportSettingFactory> WithReportSetting<T1>(this CombinedResult<ReportPlanFactory, T1> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, InnerReportPlanReportSettingFactory> WithReportSetting<T1>(this CombinedResult<T1, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2>(this CombinedResult<ReportPlanFactory, T1, T2> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2>(this CombinedResult<T1, ReportPlanFactory, T2> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2>(this CombinedResult<T1, T2, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, T3, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3>(this CombinedResult<ReportPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, T3, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3>(this CombinedResult<T1, ReportPlanFactory, T2, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, T3, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3>(this CombinedResult<T1, T2, ReportPlanFactory, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportPlanFactory, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, T3, T4, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3, T4>(this CombinedResult<ReportPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, T3, T4, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3, T4>(this CombinedResult<T1, ReportPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, T3, T4, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReportPlanFactory, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportPlanFactory, T4, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReportPlanFactory, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReportPlanFactory, InnerReportPlanReportSettingFactory> WithReportSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportSetting(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1>(this CombinedResult<ReportPlanFactory, T1> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1>(this CombinedResult<T1, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2>(this CombinedResult<ReportPlanFactory, T1, T2> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2>(this CombinedResult<T1, ReportPlanFactory, T2> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2>(this CombinedResult<T1, T2, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, T3, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3>(this CombinedResult<ReportPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, T3, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3>(this CombinedResult<T1, ReportPlanFactory, T2, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, T3, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3>(this CombinedResult<T1, T2, ReportPlanFactory, T3> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportPlanFactory, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReportPlanFactory, T1, T2, T3, T4, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3, T4>(this CombinedResult<ReportPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportPlanFactory, T2, T3, T4, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3, T4>(this CombinedResult<T1, ReportPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportPlanFactory, T3, T4, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReportPlanFactory, T3, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportPlanFactory, T4, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReportPlanFactory, T4> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReportPlanFactory, InnerReportPlanReportDeliveryChannelFactory> WithReportDeliveryChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReportPlanFactory> combinedResult, Action<Humidifier.Backup.ReportPlanTypes.ReportDeliveryChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportDeliveryChannel(combinedResult.T5, subFactoryAction));
}
