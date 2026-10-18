// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAthenaParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AthenaParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AthenaParameters>
{

    internal InnerDataSourceIdentityCenterConfigurationFactory IdentityCenterConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.AthenaParameters Create()
    {
        var athenaParametersResult = CreateAthenaParameters();
        factoryAction?.Invoke(athenaParametersResult);

        return athenaParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AthenaParameters CreateAthenaParameters()
    {
        var athenaParametersResult = new Humidifier.QuickSight.DataSourceTypes.AthenaParameters();

        return athenaParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.AthenaParameters result)
    {
        base.CreateChildren(result);

        result.IdentityCenterConfiguration ??= IdentityCenterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceAthenaParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceAthenaParametersFactory, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration(this InnerDataSourceAthenaParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityCenterConfigurationFactory = new InnerDataSourceIdentityCenterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityCenterConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceAthenaParametersFactory, T1, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<InnerDataSourceAthenaParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceAthenaParametersFactory, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<T1, InnerDataSourceAthenaParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2, T3, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2, T3, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory, T3, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceAthenaParametersFactory, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceAthenaParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2, T3, T4, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceAthenaParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2, T3, T4, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceAthenaParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory, T3, T4, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceAthenaParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceAthenaParametersFactory, T4, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceAthenaParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceAthenaParametersFactory, InnerDataSourceIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceAthenaParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T5, subFactoryAction).T2);
}
