// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupGateway;

public class InnerGatewayTagsItemsFactory(Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.BackupGateway.GatewayTypes.TagsItems>
{

    protected override Humidifier.BackupGateway.GatewayTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.BackupGateway.GatewayTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.BackupGateway.GatewayTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerGatewayTagsItemsFactoryExtensions
{
}
