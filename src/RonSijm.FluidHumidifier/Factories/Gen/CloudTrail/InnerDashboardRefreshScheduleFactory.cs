// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerDashboardRefreshScheduleFactory(Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule>
{

    internal InnerDashboardFrequencyFactory FrequencyFactory { get; set; }

    protected override Humidifier.CloudTrail.DashboardTypes.RefreshSchedule Create()
    {
        var refreshScheduleResult = CreateRefreshSchedule();
        factoryAction?.Invoke(refreshScheduleResult);

        return refreshScheduleResult;
    }

    private Humidifier.CloudTrail.DashboardTypes.RefreshSchedule CreateRefreshSchedule()
    {
        var refreshScheduleResult = new Humidifier.CloudTrail.DashboardTypes.RefreshSchedule();

        return refreshScheduleResult;
    }
    public override void CreateChildren(Humidifier.CloudTrail.DashboardTypes.RefreshSchedule result)
    {
        base.CreateChildren(result);

        result.Frequency ??= FrequencyFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardRefreshScheduleFactoryExtensions
{
    public static CombinedResult<InnerDashboardRefreshScheduleFactory, InnerDashboardFrequencyFactory> WithFrequency(this InnerDashboardRefreshScheduleFactory parentFactory, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null)
    {
        parentFactory.FrequencyFactory = new InnerDashboardFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FrequencyFactory);
    }

    public static CombinedResult<InnerDashboardRefreshScheduleFactory, T1, InnerDashboardFrequencyFactory> WithFrequency<T1>(this CombinedResult<InnerDashboardRefreshScheduleFactory, T1> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardRefreshScheduleFactory, InnerDashboardFrequencyFactory> WithFrequency<T1>(this CombinedResult<T1, InnerDashboardRefreshScheduleFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2, InnerDashboardFrequencyFactory> WithFrequency<T1, T2>(this CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2, InnerDashboardFrequencyFactory> WithFrequency<T1, T2>(this CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory, InnerDashboardFrequencyFactory> WithFrequency<T1, T2>(this CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2, T3, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3>(this CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2, T3, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3>(this CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory, T3, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardRefreshScheduleFactory, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardRefreshScheduleFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2, T3, T4, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3, T4>(this CombinedResult<InnerDashboardRefreshScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2, T3, T4, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardRefreshScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory, T3, T4, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardRefreshScheduleFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardRefreshScheduleFactory, T4, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardRefreshScheduleFactory, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardRefreshScheduleFactory, InnerDashboardFrequencyFactory> WithFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardRefreshScheduleFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrequency(combinedResult.T5, subFactoryAction));
}
