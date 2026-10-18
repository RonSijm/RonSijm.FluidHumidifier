// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBParameterGroupTagsItemsFactory(Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems>
{

    protected override Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerInfluxDBParameterGroupTagsItemsFactoryExtensions
{
}
