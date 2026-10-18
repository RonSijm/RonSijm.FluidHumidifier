// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InfluxDBParameterGroupFactory(string resourceName = null, Action<Humidifier.Timestream.InfluxDBParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.Timestream.InfluxDBParameterGroup>(resourceName)
{

    internal List<InnerInfluxDBParameterGroupTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerInfluxDBParameterGroupParametersFactory ParametersFactory { get; set; }

    protected override Humidifier.Timestream.InfluxDBParameterGroup Create()
    {
        var influxDBParameterGroupResult = CreateInfluxDBParameterGroup();
        factoryAction?.Invoke(influxDBParameterGroupResult);

        return influxDBParameterGroupResult;
    }

    private Humidifier.Timestream.InfluxDBParameterGroup CreateInfluxDBParameterGroup()
    {
        var influxDBParameterGroupResult = new Humidifier.Timestream.InfluxDBParameterGroup
        {
            GivenName = InputResourceName,
        };

        return influxDBParameterGroupResult;
    }
    public override void CreateChildren(Humidifier.Timestream.InfluxDBParameterGroup result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Parameters ??= ParametersFactory?.Build();
    }

} // End Of Class

public static class InfluxDBParameterGroupFactoryExtensions
{
    public static CombinedResult<InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags(this InfluxDBParameterGroupFactory parentFactory, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerInfluxDBParameterGroupTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupParametersFactory> WithParameters(this InfluxDBParameterGroupFactory parentFactory, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerInfluxDBParameterGroupParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<InfluxDBParameterGroupFactory, T1, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1>(this CombinedResult<InfluxDBParameterGroupFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, T4, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, T4, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, T4, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, T4, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1>(this CombinedResult<InfluxDBParameterGroupFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1>(this CombinedResult<T1, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, T4, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<InfluxDBParameterGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, T4, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBParameterGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, T4, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBParameterGroupFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, T4, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBParameterGroupFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBParameterGroupFactory, InnerInfluxDBParameterGroupParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBParameterGroupFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction).T2);
}
