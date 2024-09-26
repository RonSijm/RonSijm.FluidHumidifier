// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDataSetRefreshPropertiesFactory(Action<Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties>
{

    internal InnerDataSetRefreshConfigurationFactory RefreshConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties Create()
    {
        var dataSetRefreshPropertiesResult = CreateDataSetRefreshProperties();
        factoryAction?.Invoke(dataSetRefreshPropertiesResult);

        return dataSetRefreshPropertiesResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties CreateDataSetRefreshProperties()
    {
        var dataSetRefreshPropertiesResult = new Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties();

        return dataSetRefreshPropertiesResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties result)
    {
        base.CreateChildren(result);

        result.RefreshConfiguration ??= RefreshConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetDataSetRefreshPropertiesFactoryExtensions
{
    public static CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration(this InnerDataSetDataSetRefreshPropertiesFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null)
    {
        parentFactory.RefreshConfigurationFactory = new InnerDataSetRefreshConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RefreshConfigurationFactory);
    }

    public static CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1>(this CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1>(this CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2>(this CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2, T3, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2, T3, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory, T3, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDataSetRefreshPropertiesFactory, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetDataSetRefreshPropertiesFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2, T3, T4, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSetDataSetRefreshPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2, T3, T4, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetDataSetRefreshPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory, T3, T4, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetDataSetRefreshPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDataSetRefreshPropertiesFactory, T4, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetDataSetRefreshPropertiesFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetDataSetRefreshPropertiesFactory, InnerDataSetRefreshConfigurationFactory> WithRefreshConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetDataSetRefreshPropertiesFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshConfiguration(combinedResult.T5, subFactoryAction));
}
