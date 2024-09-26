// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxOpenZFSProtocolFactory(Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol>
{

    internal InnerLocationFSxOpenZFSNFSFactory NFSFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol Create()
    {
        var protocolResult = CreateProtocol();
        factoryAction?.Invoke(protocolResult);

        return protocolResult;
    }

    private Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol CreateProtocol()
    {
        var protocolResult = new Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol();

        return protocolResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol result)
    {
        base.CreateChildren(result);

        result.NFS ??= NFSFactory?.Build();
    }

} // End Of Class

public static class InnerLocationFSxOpenZFSProtocolFactoryExtensions
{
    public static CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, InnerLocationFSxOpenZFSNFSFactory> WithNFS(this InnerLocationFSxOpenZFSProtocolFactory parentFactory, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null)
    {
        parentFactory.NFSFactory = new InnerLocationFSxOpenZFSNFSFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NFSFactory);
    }

    public static CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1>(this CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1>(this CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2>(this CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2>(this CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2, T3, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2, T3, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory, T3, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSProtocolFactory, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2, T3, T4, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxOpenZFSProtocolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2, T3, T4, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxOpenZFSProtocolFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory, T3, T4, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxOpenZFSProtocolFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSProtocolFactory, T4, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxOpenZFSProtocolFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxOpenZFSProtocolFactory, InnerLocationFSxOpenZFSNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxOpenZFSProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T5, subFactoryAction));
}
