// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class PackageFactory(string resourceName = null, Action<Humidifier.Panorama.Package> factoryAction = null) : ResourceFactory<Humidifier.Panorama.Package>(resourceName)
{

    internal InnerPackageStorageLocationFactory StorageLocationFactory { get; set; }

    protected override Humidifier.Panorama.Package Create()
    {
        var packageResult = CreatePackage();
        factoryAction?.Invoke(packageResult);

        return packageResult;
    }

    private Humidifier.Panorama.Package CreatePackage()
    {
        var packageResult = new Humidifier.Panorama.Package
        {
            GivenName = InputResourceName,
        };

        return packageResult;
    }
    public override void CreateChildren(Humidifier.Panorama.Package result)
    {
        base.CreateChildren(result);

        result.StorageLocation ??= StorageLocationFactory?.Build();
    }

} // End Of Class

public static class PackageFactoryExtensions
{
    public static CombinedResult<PackageFactory, InnerPackageStorageLocationFactory> WithStorageLocation(this PackageFactory parentFactory, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null)
    {
        parentFactory.StorageLocationFactory = new InnerPackageStorageLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageLocationFactory);
    }

    public static CombinedResult<PackageFactory, T1, InnerPackageStorageLocationFactory> WithStorageLocation<T1>(this CombinedResult<PackageFactory, T1> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageFactory, InnerPackageStorageLocationFactory> WithStorageLocation<T1>(this CombinedResult<T1, PackageFactory> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PackageFactory, T1, T2, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<PackageFactory, T1, T2> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageFactory, T2, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, PackageFactory, T2> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageFactory, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, T2, PackageFactory> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PackageFactory, T1, T2, T3, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<PackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageFactory, T2, T3, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, PackageFactory, T2, T3> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageFactory, T3, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, PackageFactory, T3> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackageFactory, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, PackageFactory> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PackageFactory, T1, T2, T3, T4, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<PackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageFactory, T2, T3, T4, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, PackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageFactory, T3, T4, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, PackageFactory, T3, T4> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackageFactory, T4, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PackageFactory, T4> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PackageFactory, InnerPackageStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PackageFactory> combinedResult, Action<Humidifier.Panorama.PackageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T5, subFactoryAction));
}
