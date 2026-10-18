// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicV2CustomInstructionsFactory(Action<Humidifier.QuickSight.TopicV2Types.CustomInstructions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicV2Types.CustomInstructions>
{

    protected override Humidifier.QuickSight.TopicV2Types.CustomInstructions Create()
    {
        var customInstructionsResult = CreateCustomInstructions();
        factoryAction?.Invoke(customInstructionsResult);

        return customInstructionsResult;
    }

    private Humidifier.QuickSight.TopicV2Types.CustomInstructions CreateCustomInstructions()
    {
        var customInstructionsResult = new Humidifier.QuickSight.TopicV2Types.CustomInstructions();

        return customInstructionsResult;
    }

} // End Of Class

public static class InnerTopicV2CustomInstructionsFactoryExtensions
{
}
