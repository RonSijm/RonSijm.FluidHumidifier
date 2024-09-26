// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.Events.Connection> factoryAction = null) : ResourceFactory<Humidifier.Events.Connection>(resourceName)
{

    internal InnerConnectionAuthParametersFactory AuthParametersFactory { get; set; }

    protected override Humidifier.Events.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.Events.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.Events.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }
    public override void CreateChildren(Humidifier.Events.Connection result)
    {
        base.CreateChildren(result);

        result.AuthParameters ??= AuthParametersFactory?.Build();
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
    public static CombinedResult<ConnectionFactory, InnerConnectionAuthParametersFactory> WithAuthParameters(this ConnectionFactory parentFactory, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null)
    {
        parentFactory.AuthParametersFactory = new InnerConnectionAuthParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthParametersFactory);
    }

    public static CombinedResult<ConnectionFactory, T1, InnerConnectionAuthParametersFactory> WithAuthParameters<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionAuthParametersFactory> WithAuthParameters<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionAuthParametersFactory> WithAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.AuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthParameters(combinedResult.T5, subFactoryAction));
}
