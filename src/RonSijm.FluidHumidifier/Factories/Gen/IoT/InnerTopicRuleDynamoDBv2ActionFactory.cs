// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleDynamoDBv2ActionFactory(Action<Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action>
{

    internal InnerTopicRulePutItemInputFactory PutItemFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action Create()
    {
        var dynamoDBv2ActionResult = CreateDynamoDBv2Action();
        factoryAction?.Invoke(dynamoDBv2ActionResult);

        return dynamoDBv2ActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action CreateDynamoDBv2Action()
    {
        var dynamoDBv2ActionResult = new Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action();

        return dynamoDBv2ActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action result)
    {
        base.CreateChildren(result);

        result.PutItem ??= PutItemFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleDynamoDBv2ActionFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, InnerTopicRulePutItemInputFactory> WithPutItem(this InnerTopicRuleDynamoDBv2ActionFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null)
    {
        parentFactory.PutItemFactory = new InnerTopicRulePutItemInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PutItemFactory);
    }

    public static CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, InnerTopicRulePutItemInputFactory> WithPutItem<T1>(this CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithPutItem(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, InnerTopicRulePutItemInputFactory> WithPutItem<T1>(this CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithPutItem(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2>(this CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2>(this CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2, T3, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3>(this CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2, T3, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory, T3, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleDynamoDBv2ActionFactory, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleDynamoDBv2ActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2, T3, T4, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleDynamoDBv2ActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2, T3, T4, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleDynamoDBv2ActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory, T3, T4, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleDynamoDBv2ActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleDynamoDBv2ActionFactory, T4, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleDynamoDBv2ActionFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleDynamoDBv2ActionFactory, InnerTopicRulePutItemInputFactory> WithPutItem<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleDynamoDBv2ActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPutItem(combinedResult.T5, subFactoryAction));
}
