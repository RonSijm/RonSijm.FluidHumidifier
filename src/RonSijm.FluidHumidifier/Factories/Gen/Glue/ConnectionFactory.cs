// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.Glue.Connection> factoryAction = null) : ResourceFactory<Humidifier.Glue.Connection>(resourceName)
{

    internal InnerConnectionConnectionInputFactory ConnectionInputFactory { get; set; }

    protected override Humidifier.Glue.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.Glue.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.Glue.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }
    public override void CreateChildren(Humidifier.Glue.Connection result)
    {
        base.CreateChildren(result);

        result.ConnectionInput ??= ConnectionInputFactory?.Build();
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
    public static CombinedResult<ConnectionFactory, InnerConnectionConnectionInputFactory> WithConnectionInput(this ConnectionFactory parentFactory, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null)
    {
        parentFactory.ConnectionInputFactory = new InnerConnectionConnectionInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionInputFactory);
    }

    public static CombinedResult<ConnectionFactory, T1, InnerConnectionConnectionInputFactory> WithConnectionInput<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionConnectionInputFactory> WithConnectionInput<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionConnectionInputFactory> WithConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypes.ConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionInput(combinedResult.T5, subFactoryAction));
}
