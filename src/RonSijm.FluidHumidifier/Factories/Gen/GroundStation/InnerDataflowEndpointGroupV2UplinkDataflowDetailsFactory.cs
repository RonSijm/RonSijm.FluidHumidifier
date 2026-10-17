// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails>
{

    internal InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory AgentConnectionDetailsFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails Create()
    {
        var uplinkDataflowDetailsResult = CreateUplinkDataflowDetails();
        factoryAction?.Invoke(uplinkDataflowDetailsResult);

        return uplinkDataflowDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails CreateUplinkDataflowDetails()
    {
        var uplinkDataflowDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails();

        return uplinkDataflowDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails result)
    {
        base.CreateChildren(result);

        result.AgentConnectionDetails ??= AgentConnectionDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails(this InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null)
    {
        parentFactory.AgentConnectionDetailsFactory = new InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentConnectionDetailsFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2, T3, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T3, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T3, T4, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T4, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2UplinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T5, subFactoryAction).T2);
}
