// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class CidrCollectionFactory(string resourceName = null, Action<Humidifier.Route53.CidrCollection> factoryAction = null) : ResourceFactory<Humidifier.Route53.CidrCollection>(resourceName)
{

    internal List<InnerCidrCollectionLocationFactory> LocationsFactories { get; set; } = [];

    protected override Humidifier.Route53.CidrCollection Create()
    {
        var cidrCollectionResult = CreateCidrCollection();
        factoryAction?.Invoke(cidrCollectionResult);

        return cidrCollectionResult;
    }

    private Humidifier.Route53.CidrCollection CreateCidrCollection()
    {
        var cidrCollectionResult = new Humidifier.Route53.CidrCollection
        {
            GivenName = InputResourceName,
        };

        return cidrCollectionResult;
    }
    public override void CreateChildren(Humidifier.Route53.CidrCollection result)
    {
        base.CreateChildren(result);

        result.Locations = LocationsFactories.Any() ? LocationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CidrCollectionFactoryExtensions
{
    public static CombinedResult<CidrCollectionFactory, InnerCidrCollectionLocationFactory> WithLocations(this CidrCollectionFactory parentFactory, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null)
    {
        var factory = new InnerCidrCollectionLocationFactory(subFactoryAction);
        parentFactory.LocationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CidrCollectionFactory, T1, InnerCidrCollectionLocationFactory> WithLocations<T1>(this CombinedResult<CidrCollectionFactory, T1> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CidrCollectionFactory, InnerCidrCollectionLocationFactory> WithLocations<T1>(this CombinedResult<T1, CidrCollectionFactory> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CidrCollectionFactory, T1, T2, InnerCidrCollectionLocationFactory> WithLocations<T1, T2>(this CombinedResult<CidrCollectionFactory, T1, T2> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CidrCollectionFactory, T2, InnerCidrCollectionLocationFactory> WithLocations<T1, T2>(this CombinedResult<T1, CidrCollectionFactory, T2> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CidrCollectionFactory, InnerCidrCollectionLocationFactory> WithLocations<T1, T2>(this CombinedResult<T1, T2, CidrCollectionFactory> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CidrCollectionFactory, T1, T2, T3, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3>(this CombinedResult<CidrCollectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CidrCollectionFactory, T2, T3, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3>(this CombinedResult<T1, CidrCollectionFactory, T2, T3> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CidrCollectionFactory, T3, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3>(this CombinedResult<T1, T2, CidrCollectionFactory, T3> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CidrCollectionFactory, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3>(this CombinedResult<T1, T2, T3, CidrCollectionFactory> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CidrCollectionFactory, T1, T2, T3, T4, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3, T4>(this CombinedResult<CidrCollectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CidrCollectionFactory, T2, T3, T4, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3, T4>(this CombinedResult<T1, CidrCollectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CidrCollectionFactory, T3, T4, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, CidrCollectionFactory, T3, T4> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CidrCollectionFactory, T4, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CidrCollectionFactory, T4> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CidrCollectionFactory, InnerCidrCollectionLocationFactory> WithLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CidrCollectionFactory> combinedResult, Action<Humidifier.Route53.CidrCollectionTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocations(combinedResult.T5, subFactoryAction));
}
