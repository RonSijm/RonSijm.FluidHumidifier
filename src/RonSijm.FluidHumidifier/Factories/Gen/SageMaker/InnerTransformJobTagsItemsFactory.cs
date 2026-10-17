// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobTagsItemsFactory(Action<Humidifier.SageMaker.TransformJobTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.TagsItems>
{

    protected override Humidifier.SageMaker.TransformJobTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.SageMaker.TransformJobTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerTransformJobTagsItemsFactoryExtensions
{
}
