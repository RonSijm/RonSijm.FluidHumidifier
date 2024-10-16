// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxONTAPProtocolFactory(Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol>
{

    internal InnerLocationFSxONTAPSMBFactory SMBFactory { get; set; }

    internal InnerLocationFSxONTAPNFSFactory NFSFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxONTAPTypes.Protocol Create()
    {
        var protocolResult = CreateProtocol();
        factoryAction?.Invoke(protocolResult);

        return protocolResult;
    }

    private Humidifier.DataSync.LocationFSxONTAPTypes.Protocol CreateProtocol()
    {
        var protocolResult = new Humidifier.DataSync.LocationFSxONTAPTypes.Protocol();

        return protocolResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxONTAPTypes.Protocol result)
    {
        base.CreateChildren(result);

        result.SMB ??= SMBFactory?.Build();
        result.NFS ??= NFSFactory?.Build();
    }

} // End Of Class

public static class InnerLocationFSxONTAPProtocolFactoryExtensions
{
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPSMBFactory> WithSMB(this InnerLocationFSxONTAPProtocolFactory parentFactory, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null)
    {
        parentFactory.SMBFactory = new InnerLocationFSxONTAPSMBFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SMBFactory);
    }

    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPNFSFactory> WithNFS(this InnerLocationFSxONTAPProtocolFactory parentFactory, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null)
    {
        parentFactory.NFSFactory = new InnerLocationFSxONTAPNFSFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NFSFactory);
    }

    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, InnerLocationFSxONTAPSMBFactory> WithSMB<T1>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, WithSMB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPSMBFactory> WithSMB<T1>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, WithSMB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, T4, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, T4, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, T4, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, T4, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPSMBFactory> WithSMB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMB(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, InnerLocationFSxONTAPNFSFactory> WithNFS<T1>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPNFSFactory> WithNFS<T1>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, T4, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxONTAPProtocolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, T4, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxONTAPProtocolFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, T4, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxONTAPProtocolFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, T4, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPProtocolFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory, InnerLocationFSxONTAPNFSFactory> WithNFS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.NFS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNFS(combinedResult.T5, subFactoryAction));
}
