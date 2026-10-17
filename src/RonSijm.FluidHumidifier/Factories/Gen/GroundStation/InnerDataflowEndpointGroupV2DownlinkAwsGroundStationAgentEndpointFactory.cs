// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint>
{

    internal InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory DataflowDetailsFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint Create()
    {
        var downlinkAwsGroundStationAgentEndpointResult = CreateDownlinkAwsGroundStationAgentEndpoint();
        factoryAction?.Invoke(downlinkAwsGroundStationAgentEndpointResult);

        return downlinkAwsGroundStationAgentEndpointResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint CreateDownlinkAwsGroundStationAgentEndpoint()
    {
        var downlinkAwsGroundStationAgentEndpointResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint();

        return downlinkAwsGroundStationAgentEndpointResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint result)
    {
        base.CreateChildren(result);

        result.DataflowDetails ??= DataflowDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails(this InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null)
    {
        parentFactory.DataflowDetailsFactory = new InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataflowDetailsFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T3, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T3, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T4, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2DownlinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2DownlinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T5, subFactoryAction).T2);
}
