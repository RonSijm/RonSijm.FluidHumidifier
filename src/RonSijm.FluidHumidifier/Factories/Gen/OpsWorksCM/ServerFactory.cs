// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorksCM;

public class ServerFactory(string resourceName = null, Action<Humidifier.OpsWorksCM.Server> factoryAction = null) : ResourceFactory<Humidifier.OpsWorksCM.Server>(resourceName)
{

    internal List<InnerServerEngineAttributeFactory> EngineAttributesFactories { get; set; } = [];

    protected override Humidifier.OpsWorksCM.Server Create()
    {
        var serverResult = CreateServer();
        factoryAction?.Invoke(serverResult);

        return serverResult;
    }

    private Humidifier.OpsWorksCM.Server CreateServer()
    {
        var serverResult = new Humidifier.OpsWorksCM.Server
        {
            GivenName = InputResourceName,
        };

        return serverResult;
    }
    public override void CreateChildren(Humidifier.OpsWorksCM.Server result)
    {
        base.CreateChildren(result);

        result.EngineAttributes = EngineAttributesFactories.Any() ? EngineAttributesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ServerFactoryExtensions
{
    public static CombinedResult<ServerFactory, InnerServerEngineAttributeFactory> WithEngineAttributes(this ServerFactory parentFactory, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null)
    {
        var factory = new InnerServerEngineAttributeFactory(subFactoryAction);
        parentFactory.EngineAttributesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ServerFactory, T1, InnerServerEngineAttributeFactory> WithEngineAttributes<T1>(this CombinedResult<ServerFactory, T1> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerFactory, InnerServerEngineAttributeFactory> WithEngineAttributes<T1>(this CombinedResult<T1, ServerFactory> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerFactory, T1, T2, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2>(this CombinedResult<ServerFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerFactory, T2, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2>(this CombinedResult<T1, ServerFactory, T2> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerFactory, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2>(this CombinedResult<T1, T2, ServerFactory> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerFactory, T1, T2, T3, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3>(this CombinedResult<ServerFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerFactory, T2, T3, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3>(this CombinedResult<T1, ServerFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerFactory, T3, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3>(this CombinedResult<T1, T2, ServerFactory, T3> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerFactory, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerFactory> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerFactory, T1, T2, T3, T4, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3, T4>(this CombinedResult<ServerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerFactory, T2, T3, T4, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3, T4>(this CombinedResult<T1, ServerFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerFactory, T3, T4, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerFactory, T4, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerFactory, T4> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerFactory, InnerServerEngineAttributeFactory> WithEngineAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerFactory> combinedResult, Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineAttributes(combinedResult.T5, subFactoryAction));
}
