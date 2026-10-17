// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceTagsItemsFactory(Action<Humidifier.Grafana.WorkspaceTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.TagsItems>
{

    protected override Humidifier.Grafana.WorkspaceTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Grafana.WorkspaceTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerWorkspaceTagsItemsFactoryExtensions
{
}
