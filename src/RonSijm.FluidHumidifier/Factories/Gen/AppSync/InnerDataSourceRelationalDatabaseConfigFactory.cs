// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceRelationalDatabaseConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig>
{

    internal InnerDataSourceRdsHttpEndpointConfigFactory RdsHttpEndpointConfigFactory { get; set; }

    protected override Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig Create()
    {
        var relationalDatabaseConfigResult = CreateRelationalDatabaseConfig();
        factoryAction?.Invoke(relationalDatabaseConfigResult);

        return relationalDatabaseConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig CreateRelationalDatabaseConfig()
    {
        var relationalDatabaseConfigResult = new Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig();

        return relationalDatabaseConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig result)
    {
        base.CreateChildren(result);

        result.RdsHttpEndpointConfig ??= RdsHttpEndpointConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceRelationalDatabaseConfigFactoryExtensions
{
    public static CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig(this InnerDataSourceRelationalDatabaseConfigFactory parentFactory, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null)
    {
        parentFactory.RdsHttpEndpointConfigFactory = new InnerDataSourceRdsHttpEndpointConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RdsHttpEndpointConfigFactory);
    }

    public static CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1>(this CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1>(this CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2>(this CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2>(this CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2, T3, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3>(this CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2, T3, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory, T3, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceRelationalDatabaseConfigFactory, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceRelationalDatabaseConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2, T3, T4, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceRelationalDatabaseConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2, T3, T4, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceRelationalDatabaseConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory, T3, T4, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceRelationalDatabaseConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceRelationalDatabaseConfigFactory, T4, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceRelationalDatabaseConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceRelationalDatabaseConfigFactory, InnerDataSourceRdsHttpEndpointConfigFactory> WithRdsHttpEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceRelationalDatabaseConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsHttpEndpointConfig(combinedResult.T5, subFactoryAction));
}
