// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRuleActionFactory(Action<Humidifier.VpcLattice.RuleTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.Action>
{

    internal InnerRuleForwardFactory ForwardFactory { get; set; }

    internal InnerRuleFixedResponseFactory FixedResponseFactory { get; set; }

    protected override Humidifier.VpcLattice.RuleTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.VpcLattice.RuleTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.VpcLattice.RuleTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.RuleTypes.Action result)
    {
        base.CreateChildren(result);

        result.Forward ??= ForwardFactory?.Build();
        result.FixedResponse ??= FixedResponseFactory?.Build();
    }

} // End Of Class

public static class InnerRuleActionFactoryExtensions
{
    public static CombinedResult<InnerRuleActionFactory, InnerRuleForwardFactory> WithForward(this InnerRuleActionFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null)
    {
        parentFactory.ForwardFactory = new InnerRuleForwardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardFactory);
    }

    public static CombinedResult<InnerRuleActionFactory, InnerRuleFixedResponseFactory> WithFixedResponse(this InnerRuleActionFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null)
    {
        parentFactory.FixedResponseFactory = new InnerRuleFixedResponseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FixedResponseFactory);
    }

    public static CombinedResult<InnerRuleActionFactory, T1, InnerRuleForwardFactory> WithForward<T1>(this CombinedResult<InnerRuleActionFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, InnerRuleForwardFactory> WithForward<T1>(this CombinedResult<T1, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, InnerRuleForwardFactory> WithForward<T1, T2>(this CombinedResult<InnerRuleActionFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, InnerRuleForwardFactory> WithForward<T1, T2>(this CombinedResult<T1, InnerRuleActionFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, InnerRuleForwardFactory> WithForward<T1, T2>(this CombinedResult<T1, T2, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, T3, InnerRuleForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<InnerRuleActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, T3, InnerRuleForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, InnerRuleActionFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, T3, InnerRuleForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleActionFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleActionFactory, InnerRuleForwardFactory> WithForward<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, T3, T4, InnerRuleForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<InnerRuleActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, T3, T4, InnerRuleForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, T3, T4, InnerRuleForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleActionFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleActionFactory, T4, InnerRuleForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleActionFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleActionFactory, InnerRuleForwardFactory> WithForward<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Forward> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForward(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, InnerRuleFixedResponseFactory> WithFixedResponse<T1>(this CombinedResult<InnerRuleActionFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, InnerRuleFixedResponseFactory> WithFixedResponse<T1>(this CombinedResult<T1, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<InnerRuleActionFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<T1, InnerRuleActionFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2>(this CombinedResult<T1, T2, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, T3, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<InnerRuleActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, T3, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, InnerRuleActionFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, T3, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleActionFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleActionFactory, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleActionFactory, T1, T2, T3, T4, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<InnerRuleActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleActionFactory, T2, T3, T4, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleActionFactory, T3, T4, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleActionFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleActionFactory, T4, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleActionFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleActionFactory, InnerRuleFixedResponseFactory> WithFixedResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleActionFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixedResponse(combinedResult.T5, subFactoryAction));
}
