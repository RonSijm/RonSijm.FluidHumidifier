// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class StorageProfileFactory(string resourceName = null, Action<Humidifier.Deadline.StorageProfile> factoryAction = null) : ResourceFactory<Humidifier.Deadline.StorageProfile>(resourceName)
{

    internal List<InnerStorageProfileFileSystemLocationFactory> FileSystemLocationsFactories { get; set; } = [];

    protected override Humidifier.Deadline.StorageProfile Create()
    {
        var storageProfileResult = CreateStorageProfile();
        factoryAction?.Invoke(storageProfileResult);

        return storageProfileResult;
    }

    private Humidifier.Deadline.StorageProfile CreateStorageProfile()
    {
        var storageProfileResult = new Humidifier.Deadline.StorageProfile
        {
            GivenName = InputResourceName,
        };

        return storageProfileResult;
    }
    public override void CreateChildren(Humidifier.Deadline.StorageProfile result)
    {
        base.CreateChildren(result);

        result.FileSystemLocations = FileSystemLocationsFactories.Any() ? FileSystemLocationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class StorageProfileFactoryExtensions
{
    public static CombinedResult<StorageProfileFactory, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations(this StorageProfileFactory parentFactory, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null)
    {
        var factory = new InnerStorageProfileFileSystemLocationFactory(subFactoryAction);
        parentFactory.FileSystemLocationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<StorageProfileFactory, T1, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1>(this CombinedResult<StorageProfileFactory, T1> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageProfileFactory, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1>(this CombinedResult<T1, StorageProfileFactory> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageProfileFactory, T1, T2, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2>(this CombinedResult<StorageProfileFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageProfileFactory, T2, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2>(this CombinedResult<T1, StorageProfileFactory, T2> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageProfileFactory, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2>(this CombinedResult<T1, T2, StorageProfileFactory> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageProfileFactory, T1, T2, T3, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3>(this CombinedResult<StorageProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageProfileFactory, T2, T3, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3>(this CombinedResult<T1, StorageProfileFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageProfileFactory, T3, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3>(this CombinedResult<T1, T2, StorageProfileFactory, T3> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageProfileFactory, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageProfileFactory> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageProfileFactory, T1, T2, T3, T4, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3, T4>(this CombinedResult<StorageProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageProfileFactory, T2, T3, T4, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3, T4>(this CombinedResult<T1, StorageProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageProfileFactory, T3, T4, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageProfileFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageProfileFactory, T4, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageProfileFactory, T4> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageProfileFactory, InnerStorageProfileFileSystemLocationFactory> WithFileSystemLocations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageProfileFactory> combinedResult, Action<Humidifier.Deadline.StorageProfileTypes.FileSystemLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemLocations(combinedResult.T5, subFactoryAction));
}
