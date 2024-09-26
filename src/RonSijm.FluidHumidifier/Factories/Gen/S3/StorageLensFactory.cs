// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class StorageLensFactory(string resourceName = null, Action<Humidifier.S3.StorageLens> factoryAction = null) : ResourceFactory<Humidifier.S3.StorageLens>(resourceName)
{

    internal InnerStorageLensStorageLensConfigurationFactory StorageLensConfigurationFactory { get; set; }

    protected override Humidifier.S3.StorageLens Create()
    {
        var storageLensResult = CreateStorageLens();
        factoryAction?.Invoke(storageLensResult);

        return storageLensResult;
    }

    private Humidifier.S3.StorageLens CreateStorageLens()
    {
        var storageLensResult = new Humidifier.S3.StorageLens
        {
            GivenName = InputResourceName,
        };

        return storageLensResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLens result)
    {
        base.CreateChildren(result);

        result.StorageLensConfiguration ??= StorageLensConfigurationFactory?.Build();
    }

} // End Of Class

public static class StorageLensFactoryExtensions
{
    public static CombinedResult<StorageLensFactory, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration(this StorageLensFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null)
    {
        parentFactory.StorageLensConfigurationFactory = new InnerStorageLensStorageLensConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageLensConfigurationFactory);
    }

    public static CombinedResult<StorageLensFactory, T1, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1>(this CombinedResult<StorageLensFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensFactory, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1>(this CombinedResult<T1, StorageLensFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageLensFactory, T1, T2, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2>(this CombinedResult<StorageLensFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensFactory, T2, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2>(this CombinedResult<T1, StorageLensFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensFactory, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2>(this CombinedResult<T1, T2, StorageLensFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageLensFactory, T1, T2, T3, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3>(this CombinedResult<StorageLensFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensFactory, T2, T3, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3>(this CombinedResult<T1, StorageLensFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensFactory, T3, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StorageLensFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageLensFactory, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageLensFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageLensFactory, T1, T2, T3, T4, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3, T4>(this CombinedResult<StorageLensFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageLensFactory, T2, T3, T4, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StorageLensFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageLensFactory, T3, T4, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageLensFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageLensFactory, T4, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageLensFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageLensFactory, InnerStorageLensStorageLensConfigurationFactory> WithStorageLensConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageLensFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensConfiguration(combinedResult.T5, subFactoryAction));
}
