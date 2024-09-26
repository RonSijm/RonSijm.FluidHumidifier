// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceDynamoDBConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.DynamoDBConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.DynamoDBConfig>
{

    internal InnerDataSourceDeltaSyncConfigFactory DeltaSyncConfigFactory { get; set; }

    protected override Humidifier.AppSync.DataSourceTypes.DynamoDBConfig Create()
    {
        var dynamoDBConfigResult = CreateDynamoDBConfig();
        factoryAction?.Invoke(dynamoDBConfigResult);

        return dynamoDBConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.DynamoDBConfig CreateDynamoDBConfig()
    {
        var dynamoDBConfigResult = new Humidifier.AppSync.DataSourceTypes.DynamoDBConfig();

        return dynamoDBConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.DataSourceTypes.DynamoDBConfig result)
    {
        base.CreateChildren(result);

        result.DeltaSyncConfig ??= DeltaSyncConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDynamoDBConfigFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDynamoDBConfigFactory, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig(this InnerDataSourceDynamoDBConfigFactory parentFactory, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null)
    {
        parentFactory.DeltaSyncConfigFactory = new InnerDataSourceDeltaSyncConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeltaSyncConfigFactory);
    }

    public static CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1>(this CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1>(this CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2>(this CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2>(this CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2, T3, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3>(this CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2, T3, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory, T3, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDynamoDBConfigFactory, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDynamoDBConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2, T3, T4, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDynamoDBConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2, T3, T4, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDynamoDBConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory, T3, T4, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDynamoDBConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDynamoDBConfigFactory, T4, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDynamoDBConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDynamoDBConfigFactory, InnerDataSourceDeltaSyncConfigFactory> WithDeltaSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDynamoDBConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaSyncConfig(combinedResult.T5, subFactoryAction));
}
