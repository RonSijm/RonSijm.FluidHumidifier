// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleDynamoDBActionFactory(Action<Humidifier.IoT.TopicRuleTypes.DynamoDBAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.DynamoDBAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.DynamoDBAction Create()
    {
        var dynamoDBActionResult = CreateDynamoDBAction();
        factoryAction?.Invoke(dynamoDBActionResult);

        return dynamoDBActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.DynamoDBAction CreateDynamoDBAction()
    {
        var dynamoDBActionResult = new Humidifier.IoT.TopicRuleTypes.DynamoDBAction();

        return dynamoDBActionResult;
    }

} // End Of Class

public static class InnerTopicRuleDynamoDBActionFactoryExtensions
{
}
