// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerExperimentTagsItemsFactory(Action<Humidifier.SageMaker.ExperimentTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ExperimentTypes.TagsItems>
{

    protected override Humidifier.SageMaker.ExperimentTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.SageMaker.ExperimentTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.SageMaker.ExperimentTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerExperimentTagsItemsFactoryExtensions
{
}
