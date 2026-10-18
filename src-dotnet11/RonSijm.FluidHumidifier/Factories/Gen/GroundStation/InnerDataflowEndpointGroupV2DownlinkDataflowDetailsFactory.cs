// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails>
{

    internal InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory AgentConnectionDetailsFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails Create()
    {
        var downlinkDataflowDetailsResult = CreateDownlinkDataflowDetails();
        factoryAction?.Invoke(downlinkDataflowDetailsResult);

        return downlinkDataflowDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails CreateDownlinkDataflowDetails()
    {
        var downlinkDataflowDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails();

        return downlinkDataflowDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails result)
    {
        base.CreateChildren(result);

        result.AgentConnectionDetails ??= AgentConnectionDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails(this InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null)
    {
        parentFactory.AgentConnectionDetailsFactory = new InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentConnectionDetailsFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2, T3, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T3, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T3, T4, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T4, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory, InnerDataflowEndpointGroupV2DownlinkConnectionDetailsFactory> WithAgentConnectionDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentConnectionDetails(combinedResult.T5, subFactoryAction).T2);
}
