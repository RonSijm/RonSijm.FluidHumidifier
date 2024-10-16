// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRulePutItemInputFactory(Action<Humidifier.IoT.TopicRuleTypes.PutItemInput> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.PutItemInput>
{

    protected override Humidifier.IoT.TopicRuleTypes.PutItemInput Create()
    {
        var putItemInputResult = CreatePutItemInput();
        factoryAction?.Invoke(putItemInputResult);

        return putItemInputResult;
    }

    private Humidifier.IoT.TopicRuleTypes.PutItemInput CreatePutItemInput()
    {
        var putItemInputResult = new Humidifier.IoT.TopicRuleTypes.PutItemInput();

        return putItemInputResult;
    }

} // End Of Class

public static class InnerTopicRulePutItemInputFactoryExtensions
{
}
