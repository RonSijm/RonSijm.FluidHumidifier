// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint>
{

    internal InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory DataflowDetailsFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint Create()
    {
        var uplinkAwsGroundStationAgentEndpointResult = CreateUplinkAwsGroundStationAgentEndpoint();
        factoryAction?.Invoke(uplinkAwsGroundStationAgentEndpointResult);

        return uplinkAwsGroundStationAgentEndpointResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint CreateUplinkAwsGroundStationAgentEndpoint()
    {
        var uplinkAwsGroundStationAgentEndpointResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint();

        return uplinkAwsGroundStationAgentEndpointResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint result)
    {
        base.CreateChildren(result);

        result.DataflowDetails ??= DataflowDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails(this InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null)
    {
        parentFactory.DataflowDetailsFactory = new InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataflowDetailsFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T3, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T3, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T4, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory, InnerDataflowEndpointGroupV2UplinkDataflowDetailsFactory> WithDataflowDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2UplinkAwsGroundStationAgentEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowDetails(combinedResult.T5, subFactoryAction).T2);
}
