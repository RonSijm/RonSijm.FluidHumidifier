// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerCollectionGroupCapacityLimitsFactory(Action<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits>
{

    protected override Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits Create()
    {
        var capacityLimitsResult = CreateCapacityLimits();
        factoryAction?.Invoke(capacityLimitsResult);

        return capacityLimitsResult;
    }

    private Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits CreateCapacityLimits()
    {
        var capacityLimitsResult = new Humidifier.OpenSearchServerless.CollectionGroupTypes.CapacityLimits();

        return capacityLimitsResult;
    }

} // End Of Class

public static class InnerCollectionGroupCapacityLimitsFactoryExtensions
{
}
