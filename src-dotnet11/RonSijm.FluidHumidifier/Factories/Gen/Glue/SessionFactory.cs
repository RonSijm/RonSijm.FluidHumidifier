// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class SessionFactory(string resourceName = null, Action<Humidifier.Glue.Session> factoryAction = null) : ResourceFactory<Humidifier.Glue.Session>(resourceName)
{

    internal InnerSessionConnectionsListFactory ConnectionsFactory { get; set; }

    internal InnerSessionSessionCommandFactory CommandFactory { get; set; }

    protected override Humidifier.Glue.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.Glue.Session CreateSession()
    {
        var sessionResult = new Humidifier.Glue.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }
    public override void CreateChildren(Humidifier.Glue.Session result)
    {
        base.CreateChildren(result);

        result.Connections ??= ConnectionsFactory?.Build();
        result.Command ??= CommandFactory?.Build();
    }

} // End Of Class

public static class SessionFactoryExtensions
{
    public static CombinedResult<SessionFactory, InnerSessionConnectionsListFactory> WithConnections(this SessionFactory parentFactory, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null)
    {
        parentFactory.ConnectionsFactory = new InnerSessionConnectionsListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionsFactory);
    }

    public static CombinedResult<SessionFactory, InnerSessionSessionCommandFactory> WithCommand(this SessionFactory parentFactory, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null)
    {
        parentFactory.CommandFactory = new InnerSessionSessionCommandFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CommandFactory);
    }

    public static CombinedResult<SessionFactory, T1, InnerSessionConnectionsListFactory> WithConnections<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionConnectionsListFactory> WithConnections<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, InnerSessionSessionCommandFactory> WithCommand<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionSessionCommandFactory> WithCommand<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionSessionCommandFactory> WithCommand<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionSessionCommandFactory> WithCommand<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionSessionCommandFactory> WithCommand<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionSessionCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.Glue.SessionTypes.SessionCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T5, subFactoryAction).T2);
}
