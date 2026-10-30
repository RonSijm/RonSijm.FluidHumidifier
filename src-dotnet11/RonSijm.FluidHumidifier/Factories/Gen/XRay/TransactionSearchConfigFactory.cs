// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class TransactionSearchConfigFactory(string resourceName = null, Action<Humidifier.XRay.TransactionSearchConfig> factoryAction = null) : ResourceFactory<Humidifier.XRay.TransactionSearchConfig>(resourceName)
{

    internal InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory CloudWatchLogsConfigurationFactory { get; set; }

    protected override Humidifier.XRay.TransactionSearchConfig Create()
    {
        var transactionSearchConfigResult = CreateTransactionSearchConfig();
        factoryAction?.Invoke(transactionSearchConfigResult);

        return transactionSearchConfigResult;
    }

    private Humidifier.XRay.TransactionSearchConfig CreateTransactionSearchConfig()
    {
        var transactionSearchConfigResult = new Humidifier.XRay.TransactionSearchConfig
        {
            GivenName = InputResourceName,
        };

        return transactionSearchConfigResult;
    }
    public override void CreateChildren(Humidifier.XRay.TransactionSearchConfig result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogsConfiguration ??= CloudWatchLogsConfigurationFactory?.Build();
    }

} // End Of Class

public static class TransactionSearchConfigFactoryExtensions
{
    public static CombinedResult<TransactionSearchConfigFactory, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration(this TransactionSearchConfigFactory parentFactory, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsConfigurationFactory = new InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsConfigurationFactory);
    }

    public static CombinedResult<TransactionSearchConfigFactory, T1, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1>(this CombinedResult<TransactionSearchConfigFactory, T1> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransactionSearchConfigFactory, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1>(this CombinedResult<T1, TransactionSearchConfigFactory> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TransactionSearchConfigFactory, T1, T2, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2>(this CombinedResult<TransactionSearchConfigFactory, T1, T2> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransactionSearchConfigFactory, T2, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2>(this CombinedResult<T1, TransactionSearchConfigFactory, T2> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransactionSearchConfigFactory, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2>(this CombinedResult<T1, T2, TransactionSearchConfigFactory> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TransactionSearchConfigFactory, T1, T2, T3, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3>(this CombinedResult<TransactionSearchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransactionSearchConfigFactory, T2, T3, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3>(this CombinedResult<T1, TransactionSearchConfigFactory, T2, T3> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransactionSearchConfigFactory, T3, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TransactionSearchConfigFactory, T3> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransactionSearchConfigFactory, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransactionSearchConfigFactory> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TransactionSearchConfigFactory, T1, T2, T3, T4, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3, T4>(this CombinedResult<TransactionSearchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransactionSearchConfigFactory, T2, T3, T4, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TransactionSearchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransactionSearchConfigFactory, T3, T4, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransactionSearchConfigFactory, T3, T4> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransactionSearchConfigFactory, T4, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransactionSearchConfigFactory, T4> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TransactionSearchConfigFactory, InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory> WithCloudWatchLogsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransactionSearchConfigFactory> combinedResult, Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogsConfiguration(combinedResult.T5, subFactoryAction).T2);
}
