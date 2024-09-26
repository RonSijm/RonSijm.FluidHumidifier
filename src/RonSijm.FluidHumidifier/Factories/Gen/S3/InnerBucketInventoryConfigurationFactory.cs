// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketInventoryConfigurationFactory(Action<Humidifier.S3.BucketTypes.InventoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.InventoryConfiguration>
{

    internal InnerBucketDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.InventoryConfiguration Create()
    {
        var inventoryConfigurationResult = CreateInventoryConfiguration();
        factoryAction?.Invoke(inventoryConfigurationResult);

        return inventoryConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.InventoryConfiguration CreateInventoryConfiguration()
    {
        var inventoryConfigurationResult = new Humidifier.S3.BucketTypes.InventoryConfiguration();

        return inventoryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.InventoryConfiguration result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketInventoryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketInventoryConfigurationFactory, InnerBucketDestinationFactory> WithDestination(this InnerBucketInventoryConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerBucketDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerBucketInventoryConfigurationFactory, T1, InnerBucketDestinationFactory> WithDestination<T1>(this CombinedResult<InnerBucketInventoryConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketInventoryConfigurationFactory, InnerBucketDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketInventoryConfigurationFactory, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerBucketInventoryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketInventoryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketInventoryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketInventoryConfigurationFactory, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketInventoryConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketInventoryConfigurationFactory, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction));
}
