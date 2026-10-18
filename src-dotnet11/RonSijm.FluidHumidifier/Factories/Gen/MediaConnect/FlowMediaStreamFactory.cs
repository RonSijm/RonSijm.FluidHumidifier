// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class FlowMediaStreamFactory(string resourceName = null, Action<Humidifier.MediaConnect.FlowMediaStream> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.FlowMediaStream>(resourceName)
{

    internal InnerFlowMediaStreamMediaStreamAttributesFactory Attributes_Factory { get; set; }

    protected override Humidifier.MediaConnect.FlowMediaStream Create()
    {
        var flowMediaStreamResult = CreateFlowMediaStream();
        factoryAction?.Invoke(flowMediaStreamResult);

        return flowMediaStreamResult;
    }

    private Humidifier.MediaConnect.FlowMediaStream CreateFlowMediaStream()
    {
        var flowMediaStreamResult = new Humidifier.MediaConnect.FlowMediaStream
        {
            GivenName = InputResourceName,
        };

        return flowMediaStreamResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowMediaStream result)
    {
        base.CreateChildren(result);

        result.Attributes_ ??= Attributes_Factory?.Build();
    }

} // End Of Class

public static class FlowMediaStreamFactoryExtensions
{
    public static CombinedResult<FlowMediaStreamFactory, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_(this FlowMediaStreamFactory parentFactory, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null)
    {
        parentFactory.Attributes_Factory = new InnerFlowMediaStreamMediaStreamAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Attributes_Factory);
    }

    public static CombinedResult<FlowMediaStreamFactory, T1, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1>(this CombinedResult<FlowMediaStreamFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowMediaStreamFactory, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1>(this CombinedResult<T1, FlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FlowMediaStreamFactory, T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<FlowMediaStreamFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowMediaStreamFactory, T2, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, FlowMediaStreamFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowMediaStreamFactory, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, T2, FlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FlowMediaStreamFactory, T1, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<FlowMediaStreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowMediaStreamFactory, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, FlowMediaStreamFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowMediaStreamFactory, T3, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, FlowMediaStreamFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FlowMediaStreamFactory, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FlowMediaStreamFactory, T1, T2, T3, T4, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<FlowMediaStreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowMediaStreamFactory, T2, T3, T4, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, FlowMediaStreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowMediaStreamFactory, T3, T4, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowMediaStreamFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FlowMediaStreamFactory, T4, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowMediaStreamFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FlowMediaStreamFactory, InnerFlowMediaStreamMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T5, subFactoryAction).T2);
}
