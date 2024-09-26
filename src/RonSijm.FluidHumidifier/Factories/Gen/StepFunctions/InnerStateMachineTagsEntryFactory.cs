// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineTagsEntryFactory(Action<Humidifier.StepFunctions.StateMachineTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineTypes.TagsEntry>
{

    protected override Humidifier.StepFunctions.StateMachineTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.StepFunctions.StateMachineTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.StepFunctions.StateMachineTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerStateMachineTagsEntryFactoryExtensions
{
}
