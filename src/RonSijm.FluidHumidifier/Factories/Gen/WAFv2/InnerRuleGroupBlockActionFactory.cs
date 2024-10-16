// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupBlockActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.BlockAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.BlockAction>
{

    internal InnerRuleGroupCustomResponseFactory CustomResponseFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.BlockAction Create()
    {
        var blockActionResult = CreateBlockAction();
        factoryAction?.Invoke(blockActionResult);

        return blockActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.BlockAction CreateBlockAction()
    {
        var blockActionResult = new Humidifier.WAFv2.RuleGroupTypes.BlockAction();

        return blockActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.BlockAction result)
    {
        base.CreateChildren(result);

        result.CustomResponse ??= CustomResponseFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupBlockActionFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupBlockActionFactory, InnerRuleGroupCustomResponseFactory> WithCustomResponse(this InnerRuleGroupBlockActionFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null)
    {
        parentFactory.CustomResponseFactory = new InnerRuleGroupCustomResponseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomResponseFactory);
    }

    public static CombinedResult<InnerRuleGroupBlockActionFactory, T1, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1>(this CombinedResult<InnerRuleGroupBlockActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupBlockActionFactory, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1>(this CombinedResult<T1, InnerRuleGroupBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2, T3, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2, T3, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory, T3, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupBlockActionFactory, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2, T3, T4, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupBlockActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2, T3, T4, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupBlockActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory, T3, T4, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupBlockActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupBlockActionFactory, T4, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupBlockActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupBlockActionFactory, InnerRuleGroupCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T5, subFactoryAction));
}
