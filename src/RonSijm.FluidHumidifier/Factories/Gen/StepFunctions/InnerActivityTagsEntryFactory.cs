// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerActivityTagsEntryFactory(Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.ActivityTypes.TagsEntry>
{

    protected override Humidifier.StepFunctions.ActivityTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.StepFunctions.ActivityTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.StepFunctions.ActivityTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerActivityTagsEntryFactoryExtensions
{
}
