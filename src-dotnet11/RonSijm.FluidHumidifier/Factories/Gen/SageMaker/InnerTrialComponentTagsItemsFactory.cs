// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrialComponentTagsItemsFactory(Action<Humidifier.SageMaker.TrialComponentTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrialComponentTypes.TagsItems>
{

    protected override Humidifier.SageMaker.TrialComponentTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.SageMaker.TrialComponentTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.SageMaker.TrialComponentTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerTrialComponentTagsItemsFactoryExtensions
{
}
