// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLBlockActionFactory(Action<Humidifier.WAFv2.WebACLTypes.BlockAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.BlockAction>
{

    internal InnerWebACLCustomResponseFactory CustomResponseFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.BlockAction Create()
    {
        var blockActionResult = CreateBlockAction();
        factoryAction?.Invoke(blockActionResult);

        return blockActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.BlockAction CreateBlockAction()
    {
        var blockActionResult = new Humidifier.WAFv2.WebACLTypes.BlockAction();

        return blockActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.BlockAction result)
    {
        base.CreateChildren(result);

        result.CustomResponse ??= CustomResponseFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLBlockActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLBlockActionFactory, InnerWebACLCustomResponseFactory> WithCustomResponse(this InnerWebACLBlockActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null)
    {
        parentFactory.CustomResponseFactory = new InnerWebACLCustomResponseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomResponseFactory);
    }

    public static CombinedResult<InnerWebACLBlockActionFactory, T1, InnerWebACLCustomResponseFactory> WithCustomResponse<T1>(this CombinedResult<InnerWebACLBlockActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLBlockActionFactory, InnerWebACLCustomResponseFactory> WithCustomResponse<T1>(this CombinedResult<T1, InnerWebACLBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLBlockActionFactory, T1, T2, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<InnerWebACLBlockActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLBlockActionFactory, T2, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<T1, InnerWebACLBlockActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLBlockActionFactory, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2>(this CombinedResult<T1, T2, InnerWebACLBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLBlockActionFactory, T1, T2, T3, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<InnerWebACLBlockActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLBlockActionFactory, T2, T3, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, InnerWebACLBlockActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLBlockActionFactory, T3, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLBlockActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLBlockActionFactory, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLBlockActionFactory, T1, T2, T3, T4, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<InnerWebACLBlockActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLBlockActionFactory, T2, T3, T4, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLBlockActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLBlockActionFactory, T3, T4, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLBlockActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLBlockActionFactory, T4, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLBlockActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLBlockActionFactory, InnerWebACLCustomResponseFactory> WithCustomResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLBlockActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomResponse(combinedResult.T5, subFactoryAction));
}
