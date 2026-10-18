// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicCustomInstructionsFactory(Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicTypes.CustomInstructions>
{

    protected override Humidifier.QuickSight.TopicTypes.CustomInstructions Create()
    {
        var customInstructionsResult = CreateCustomInstructions();
        factoryAction?.Invoke(customInstructionsResult);

        return customInstructionsResult;
    }

    private Humidifier.QuickSight.TopicTypes.CustomInstructions CreateCustomInstructions()
    {
        var customInstructionsResult = new Humidifier.QuickSight.TopicTypes.CustomInstructions();

        return customInstructionsResult;
    }

} // End Of Class

public static class InnerTopicCustomInstructionsFactoryExtensions
{
}
