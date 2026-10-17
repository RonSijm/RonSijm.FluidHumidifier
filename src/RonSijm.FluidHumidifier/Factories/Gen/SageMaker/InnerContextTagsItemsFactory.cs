// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerContextTagsItemsFactory(Action<Humidifier.SageMaker.ContextTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ContextTypes.TagsItems>
{

    protected override Humidifier.SageMaker.ContextTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.SageMaker.ContextTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.SageMaker.ContextTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerContextTagsItemsFactoryExtensions
{
}
