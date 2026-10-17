// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetRefreshFailureConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration>
{

    internal InnerDataSetRefreshFailureEmailAlertFactory EmailAlertFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration Create()
    {
        var refreshFailureConfigurationResult = CreateRefreshFailureConfiguration();
        factoryAction?.Invoke(refreshFailureConfigurationResult);

        return refreshFailureConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration CreateRefreshFailureConfiguration()
    {
        var refreshFailureConfigurationResult = new Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration();

        return refreshFailureConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration result)
    {
        base.CreateChildren(result);

        result.EmailAlert ??= EmailAlertFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetRefreshFailureConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert(this InnerDataSetRefreshFailureConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null)
    {
        parentFactory.EmailAlertFactory = new InnerDataSetRefreshFailureEmailAlertFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EmailAlertFactory);
    }

    public static CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1>(this CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmailAlert(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1>(this CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmailAlert(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2>(this CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2>(this CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2>(this CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2, T3, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3>(this CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2, T3, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3>(this CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory, T3, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSetRefreshFailureConfigurationFactory, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetRefreshFailureConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2, T3, T4, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3, T4>(this CombinedResult<InnerDataSetRefreshFailureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2, T3, T4, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetRefreshFailureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory, T3, T4, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetRefreshFailureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSetRefreshFailureConfigurationFactory, T4, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetRefreshFailureConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetRefreshFailureConfigurationFactory, InnerDataSetRefreshFailureEmailAlertFactory> WithEmailAlert<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetRefreshFailureConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailAlert(combinedResult.T5, subFactoryAction).T2);
}
