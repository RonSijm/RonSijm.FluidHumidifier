// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxONTAPNFSFactory(Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxONTAPTypes.NFS>
{

    internal InnerLocationFSxONTAPNfsMountOptionsFactory MountOptionsFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxONTAPTypes.NFS Create()
    {
        var nFSResult = CreateNFS();
        factoryAction?.Invoke(nFSResult);

        return nFSResult;
    }

    private Humidifier.DataSync.LocationFSxONTAPTypes.NFS CreateNFS()
    {
        var nFSResult = new Humidifier.DataSync.LocationFSxONTAPTypes.NFS();

        return nFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxONTAPTypes.NFS result)
    {
        base.CreateChildren(result);

        result.MountOptions ??= MountOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerLocationFSxONTAPNFSFactoryExtensions
{
    public static CombinedResult<InnerLocationFSxONTAPNFSFactory, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions(this InnerLocationFSxONTAPNFSFactory parentFactory, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationFSxONTAPNfsMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<InnerLocationFSxONTAPNFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, InnerLocationFSxONTAPNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2, T3, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2, T3, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory, T3, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPNFSFactory, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2, T3, T4, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxONTAPNFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2, T3, T4, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxONTAPNFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory, T3, T4, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxONTAPNFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPNFSFactory, T4, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPNFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPNFSFactory, InnerLocationFSxONTAPNfsMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction));
}
