// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowMediaStreamFactory(Action<Humidifier.MediaConnect.FlowTypes.MediaStream> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.MediaStream>
{

    internal InnerFlowMediaStreamAttributesFactory Attributes_Factory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.MediaStream Create()
    {
        var mediaStreamResult = CreateMediaStream();
        factoryAction?.Invoke(mediaStreamResult);

        return mediaStreamResult;
    }

    private Humidifier.MediaConnect.FlowTypes.MediaStream CreateMediaStream()
    {
        var mediaStreamResult = new Humidifier.MediaConnect.FlowTypes.MediaStream();

        return mediaStreamResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.MediaStream result)
    {
        base.CreateChildren(result);

        result.Attributes_ ??= Attributes_Factory?.Build();
    }

} // End Of Class

public static class InnerFlowMediaStreamFactoryExtensions
{
    public static CombinedResult<InnerFlowMediaStreamFactory, InnerFlowMediaStreamAttributesFactory> WithAttributes_(this InnerFlowMediaStreamFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null)
    {
        parentFactory.Attributes_Factory = new InnerFlowMediaStreamAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Attributes_Factory);
    }

    public static CombinedResult<InnerFlowMediaStreamFactory, T1, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1>(this CombinedResult<InnerFlowMediaStreamFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamFactory, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1>(this CombinedResult<T1, InnerFlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamFactory, T1, T2, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<InnerFlowMediaStreamFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamFactory, T2, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, InnerFlowMediaStreamFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamFactory, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, T2, InnerFlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamFactory, T1, T2, T3, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<InnerFlowMediaStreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamFactory, T2, T3, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, InnerFlowMediaStreamFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamFactory, T3, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowMediaStreamFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamFactory, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamFactory, T1, T2, T3, T4, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<InnerFlowMediaStreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamFactory, T2, T3, T4, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowMediaStreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamFactory, T3, T4, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowMediaStreamFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamFactory, T4, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamFactory, InnerFlowMediaStreamAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T5, subFactoryAction));
}
