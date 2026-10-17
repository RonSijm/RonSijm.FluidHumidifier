// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Interconnect;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.Interconnect.Connection> factoryAction = null) : ResourceFactory<Humidifier.Interconnect.Connection>(resourceName)
{

    internal InnerConnectionAttachPointFactory AttachPointFactory { get; set; }

    internal InnerConnectionRemoteAccountFactory RemoteAccountFactory { get; set; }

    protected override Humidifier.Interconnect.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.Interconnect.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.Interconnect.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }
    public override void CreateChildren(Humidifier.Interconnect.Connection result)
    {
        base.CreateChildren(result);

        result.AttachPoint ??= AttachPointFactory?.Build();
        result.RemoteAccount ??= RemoteAccountFactory?.Build();
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
    public static CombinedResult<ConnectionFactory, InnerConnectionAttachPointFactory> WithAttachPoint(this ConnectionFactory parentFactory, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null)
    {
        parentFactory.AttachPointFactory = new InnerConnectionAttachPointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AttachPointFactory);
    }

    public static CombinedResult<ConnectionFactory, InnerConnectionRemoteAccountFactory> WithRemoteAccount(this ConnectionFactory parentFactory, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null)
    {
        parentFactory.RemoteAccountFactory = new InnerConnectionRemoteAccountFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RemoteAccountFactory);
    }

    public static CombinedResult<ConnectionFactory, T1, InnerConnectionAttachPointFactory> WithAttachPoint<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionAttachPointFactory> WithAttachPoint<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionAttachPointFactory> WithAttachPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachPoint(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, WithRemoteAccount(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, WithRemoteAccount(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionRemoteAccountFactory> WithRemoteAccount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteAccount(combinedResult.T5, subFactoryAction).T2);
}
