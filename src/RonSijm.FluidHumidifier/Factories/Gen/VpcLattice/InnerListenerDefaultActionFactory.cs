// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerListenerDefaultActionFactory(Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ListenerTypes.DefaultAction>
{

    internal InnerListenerForwardFactory ForwardFactory { get; set; }

    internal InnerListenerFixedResponseFactory FixedResponseFactory { get; set; }

    protected override Humidifier.VpcLattice.ListenerTypes.DefaultAction Create()
    {
        var defaultActionResult = CreateDefaultAction();
        factoryAction?.Invoke(defaultActionResult);

        return defaultActionResult;
    }

    private Humidifier.VpcLattice.ListenerTypes.DefaultAction CreateDefaultAction()
    {
        var defaultActionResult = new Humidifier.VpcLattice.ListenerTypes.DefaultAction();

        return defaultActionResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ListenerTypes.DefaultAction result)
    {
        base.CreateChildren(result);

        result.Forward ??= ForwardFactory?.Build();
        result.FixedResponse ??= FixedResponseFactory?.Build();
    }

} // End Of Class

public static class InnerListenerDefaultActionFactoryExtensions
{
    public static CombinedResult<InnerListenerDefaultActionFactory, InnerListenerForwardFactory> WithForward(this InnerListenerDefaultActionFactory parentFactory, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null)
    {
        parentFactory.ForwardFactory = new InnerListenerForwardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardFactory);
    }

    public static CombinedResult<InnerListenerDefaultActionFactory, InnerListenerFixedResponseFactory> WithFixedResponse(this InnerListenerDefaultActionFactory parentFactory, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null)
    {
        parentFactory.FixedResponseFactory = new InnerListenerFixedResponseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FixedResponseFactory);
    }

    public static CombinedResult<InnerListenerDefaultActionFactory, T1, InnerListenerForwardFactory> WithForward<T1>(this CombinedResult<InnerListenerDefaultActionFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, InnerListenerForwardFactory> WithForward<T1>(this CombinedResult<T1, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, InnerListenerForwardFactory> WithForward<T1, T2>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, InnerListenerForwardFactory> WithForward<T1, T2>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, InnerListenerForwardFactory> WithForward<T1, T2>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, InnerListenerForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, InnerListenerForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, InnerListenerForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, InnerListenerForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, T4, InnerListenerForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, T4, InnerListenerForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, T4, InnerListenerForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, T4, InnerListenerForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerListenerDefaultActionFactory, InnerListenerForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, InnerListenerFixedResponseFactory> WithFixedResponse<T1>(this CombinedResult<InnerListenerDefaultActionFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, InnerListenerFixedResponseFactory> WithFixedResponse<T1>(this CombinedResult<T1, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, T4, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<InnerListenerDefaultActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, T4, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, InnerListenerDefaultActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, T4, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerListenerDefaultActionFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, T4, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerListenerDefaultActionFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerListenerDefaultActionFactory, InnerListenerFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerListenerDefaultActionFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T5, subFactoryAction));
}
