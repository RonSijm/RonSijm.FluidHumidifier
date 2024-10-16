// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetDatasetContentDeliveryRuleFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule>
{

    internal InnerDatasetDatasetContentDeliveryRuleDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule Create()
    {
        var datasetContentDeliveryRuleResult = CreateDatasetContentDeliveryRule();
        factoryAction?.Invoke(datasetContentDeliveryRuleResult);

        return datasetContentDeliveryRuleResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule CreateDatasetContentDeliveryRule()
    {
        var datasetContentDeliveryRuleResult = new Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule();

        return datasetContentDeliveryRuleResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDatasetContentDeliveryRuleFactoryExtensions
{
    public static CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination(this InnerDatasetDatasetContentDeliveryRuleFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerDatasetDatasetContentDeliveryRuleDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1>(this CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2, T3, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2, T3, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory, T3, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetContentDeliveryRuleFactory, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetContentDeliveryRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2, T3, T4, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDatasetContentDeliveryRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2, T3, T4, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDatasetContentDeliveryRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory, T3, T4, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDatasetContentDeliveryRuleFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetContentDeliveryRuleFactory, T4, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetContentDeliveryRuleFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetContentDeliveryRuleFactory, InnerDatasetDatasetContentDeliveryRuleDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetContentDeliveryRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction));
}
