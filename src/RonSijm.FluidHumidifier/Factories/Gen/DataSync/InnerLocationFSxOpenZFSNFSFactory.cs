// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxOpenZFSNFSFactory(Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS>
{

    internal InnerLocationFSxOpenZFSMountOptionsFactory MountOptionsFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS Create()
    {
        var nFSResult = CreateNFS();
        factoryAction?.Invoke(nFSResult);

        return nFSResult;
    }

    private Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS CreateNFS()
    {
        var nFSResult = new Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS();

        return nFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS result)
    {
        base.CreateChildren(result);

        result.MountOptions ??= MountOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerLocationFSxOpenZFSNFSFactoryExtensions
{
    public static CombinedResult<InnerLocationFSxOpenZFSNFSFactory, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions(this InnerLocationFSxOpenZFSNFSFactory parentFactory, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationFSxOpenZFSMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2, T3, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2, T3, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory, T3, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSNFSFactory, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2, T3, T4, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxOpenZFSNFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2, T3, T4, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxOpenZFSNFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory, T3, T4, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSNFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSNFSFactory, T4, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSNFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxOpenZFSNFSFactory, InnerLocationFSxOpenZFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxOpenZFSNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction));
}
