// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupRecordSetFactory(Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.RecordSet>
{

    internal InnerRecordSetGroupAliasTargetFactory AliasTargetFactory { get; set; }

    internal InnerRecordSetGroupCidrRoutingConfigFactory CidrRoutingConfigFactory { get; set; }

    internal InnerRecordSetGroupGeoLocationFactory GeoLocationFactory { get; set; }

    internal InnerRecordSetGroupGeoProximityLocationFactory GeoProximityLocationFactory { get; set; }

    protected override Humidifier.Route53.RecordSetGroupTypes.RecordSet Create()
    {
        var recordSetResult = CreateRecordSet();
        factoryAction?.Invoke(recordSetResult);

        return recordSetResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.RecordSet CreateRecordSet()
    {
        var recordSetResult = new Humidifier.Route53.RecordSetGroupTypes.RecordSet();

        return recordSetResult;
    }
    public override void CreateChildren(Humidifier.Route53.RecordSetGroupTypes.RecordSet result)
    {
        base.CreateChildren(result);

        result.AliasTarget ??= AliasTargetFactory?.Build();
        result.CidrRoutingConfig ??= CidrRoutingConfigFactory?.Build();
        result.GeoLocation ??= GeoLocationFactory?.Build();
        result.GeoProximityLocation ??= GeoProximityLocationFactory?.Build();
    }

} // End Of Class

public static class InnerRecordSetGroupRecordSetFactoryExtensions
{
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget(this InnerRecordSetGroupRecordSetFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null)
    {
        parentFactory.AliasTargetFactory = new InnerRecordSetGroupAliasTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AliasTargetFactory);
    }

    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig(this InnerRecordSetGroupRecordSetFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null)
    {
        parentFactory.CidrRoutingConfigFactory = new InnerRecordSetGroupCidrRoutingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CidrRoutingConfigFactory);
    }

    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation(this InnerRecordSetGroupRecordSetFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null)
    {
        parentFactory.GeoLocationFactory = new InnerRecordSetGroupGeoLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GeoLocationFactory);
    }

    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation(this InnerRecordSetGroupRecordSetFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null)
    {
        parentFactory.GeoProximityLocationFactory = new InnerRecordSetGroupGeoProximityLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GeoProximityLocationFactory);
    }

    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithAliasTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithAliasTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupAliasTargetFactory> WithAliasTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasTarget(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupCidrRoutingConfigFactory> WithCidrRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCidrRoutingConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoLocationFactory> WithGeoLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoLocation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGroupRecordSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGroupRecordSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGroupRecordSetFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupRecordSetFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory, InnerRecordSetGroupGeoProximityLocationFactory> WithGeoProximityLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoProximityLocation(combinedResult.T5, subFactoryAction));
}
