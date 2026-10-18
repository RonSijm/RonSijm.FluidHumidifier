// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleS3ActionFactory(Action<Humidifier.IoT.TopicRuleTypes.S3Action> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.S3Action>
{

    protected override Humidifier.IoT.TopicRuleTypes.S3Action Create()
    {
        var s3ActionResult = CreateS3Action();
        factoryAction?.Invoke(s3ActionResult);

        return s3ActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.S3Action CreateS3Action()
    {
        var s3ActionResult = new Humidifier.IoT.TopicRuleTypes.S3Action();

        return s3ActionResult;
    }

} // End Of Class

public static class InnerTopicRuleS3ActionFactoryExtensions
{
}
