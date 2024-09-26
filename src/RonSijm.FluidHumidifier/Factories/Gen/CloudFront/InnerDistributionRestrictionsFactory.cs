// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionRestrictionsFactory(Action<Humidifier.CloudFront.DistributionTypes.Restrictions> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.Restrictions>
{

    internal InnerDistributionGeoRestrictionFactory GeoRestrictionFactory { get; set; }

    protected override Humidifier.CloudFront.DistributionTypes.Restrictions Create()
    {
        var restrictionsResult = CreateRestrictions();
        factoryAction?.Invoke(restrictionsResult);

        return restrictionsResult;
    }

    private Humidifier.CloudFront.DistributionTypes.Restrictions CreateRestrictions()
    {
        var restrictionsResult = new Humidifier.CloudFront.DistributionTypes.Restrictions();

        return restrictionsResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.DistributionTypes.Restrictions result)
    {
        base.CreateChildren(result);

        result.GeoRestriction ??= GeoRestrictionFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionRestrictionsFactoryExtensions
{
    public static CombinedResult<InnerDistributionRestrictionsFactory, InnerDistributionGeoRestrictionFactory> WithGeoRestriction(this InnerDistributionRestrictionsFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null)
    {
        parentFactory.GeoRestrictionFactory = new InnerDistributionGeoRestrictionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GeoRestrictionFactory);
    }

    public static CombinedResult<InnerDistributionRestrictionsFactory, T1, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1>(this CombinedResult<InnerDistributionRestrictionsFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoRestriction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionRestrictionsFactory, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1>(this CombinedResult<T1, InnerDistributionRestrictionsFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoRestriction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionRestrictionsFactory, T1, T2, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2>(this CombinedResult<InnerDistributionRestrictionsFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionRestrictionsFactory, T2, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2>(this CombinedResult<T1, InnerDistributionRestrictionsFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionRestrictionsFactory, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2>(this CombinedResult<T1, T2, InnerDistributionRestrictionsFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionRestrictionsFactory, T1, T2, T3, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3>(this CombinedResult<InnerDistributionRestrictionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionRestrictionsFactory, T2, T3, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3>(this CombinedResult<T1, InnerDistributionRestrictionsFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionRestrictionsFactory, T3, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionRestrictionsFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionRestrictionsFactory, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionRestrictionsFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionRestrictionsFactory, T1, T2, T3, T4, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3, T4>(this CombinedResult<InnerDistributionRestrictionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionRestrictionsFactory, T2, T3, T4, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionRestrictionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionRestrictionsFactory, T3, T4, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionRestrictionsFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionRestrictionsFactory, T4, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionRestrictionsFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionRestrictionsFactory, InnerDistributionGeoRestrictionFactory> WithGeoRestriction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionRestrictionsFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoRestriction(combinedResult.T5, subFactoryAction));
}
