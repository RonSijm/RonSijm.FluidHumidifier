// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerDirectoryBucketInventoryConfigurationFactory(Action<Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration>
{

    internal InnerDirectoryBucketDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration Create()
    {
        var inventoryConfigurationResult = CreateInventoryConfiguration();
        factoryAction?.Invoke(inventoryConfigurationResult);

        return inventoryConfigurationResult;
    }

    private Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration CreateInventoryConfiguration()
    {
        var inventoryConfigurationResult = new Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration();

        return inventoryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerDirectoryBucketInventoryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, InnerDirectoryBucketDestinationFactory> WithDestination(this InnerDirectoryBucketInventoryConfigurationFactory parentFactory, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerDirectoryBucketDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, InnerDirectoryBucketDestinationFactory> WithDestination<T1>(this CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, InnerDirectoryBucketDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2, T3, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2, T3, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory, T3, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryBucketInventoryConfigurationFactory, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDirectoryBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2, T3, T4, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerDirectoryBucketInventoryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2, T3, T4, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerDirectoryBucketInventoryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory, T3, T4, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDirectoryBucketInventoryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryBucketInventoryConfigurationFactory, T4, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDirectoryBucketInventoryConfigurationFactory, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDirectoryBucketInventoryConfigurationFactory, InnerDirectoryBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDirectoryBucketInventoryConfigurationFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
}
