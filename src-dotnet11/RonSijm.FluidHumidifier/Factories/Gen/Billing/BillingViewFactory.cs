// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Billing;

public class BillingViewFactory(string resourceName = null, Action<Humidifier.Billing.BillingView> factoryAction = null) : ResourceFactory<Humidifier.Billing.BillingView>(resourceName)
{

    internal InnerBillingViewDataFilterExpressionFactory DataFilterExpressionFactory { get; set; }

    protected override Humidifier.Billing.BillingView Create()
    {
        var billingViewResult = CreateBillingView();
        factoryAction?.Invoke(billingViewResult);

        return billingViewResult;
    }

    private Humidifier.Billing.BillingView CreateBillingView()
    {
        var billingViewResult = new Humidifier.Billing.BillingView
        {
            GivenName = InputResourceName,
        };

        return billingViewResult;
    }
    public override void CreateChildren(Humidifier.Billing.BillingView result)
    {
        base.CreateChildren(result);

        result.DataFilterExpression ??= DataFilterExpressionFactory?.Build();
    }

} // End Of Class

public static class BillingViewFactoryExtensions
{
    public static CombinedResult<BillingViewFactory, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression(this BillingViewFactory parentFactory, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null)
    {
        parentFactory.DataFilterExpressionFactory = new InnerBillingViewDataFilterExpressionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataFilterExpressionFactory);
    }

    public static CombinedResult<BillingViewFactory, T1, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1>(this CombinedResult<BillingViewFactory, T1> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BillingViewFactory, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1>(this CombinedResult<T1, BillingViewFactory> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BillingViewFactory, T1, T2, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2>(this CombinedResult<BillingViewFactory, T1, T2> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BillingViewFactory, T2, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2>(this CombinedResult<T1, BillingViewFactory, T2> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BillingViewFactory, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2>(this CombinedResult<T1, T2, BillingViewFactory> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BillingViewFactory, T1, T2, T3, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3>(this CombinedResult<BillingViewFactory, T1, T2, T3> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BillingViewFactory, T2, T3, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3>(this CombinedResult<T1, BillingViewFactory, T2, T3> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BillingViewFactory, T3, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3>(this CombinedResult<T1, T2, BillingViewFactory, T3> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BillingViewFactory, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3>(this CombinedResult<T1, T2, T3, BillingViewFactory> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BillingViewFactory, T1, T2, T3, T4, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3, T4>(this CombinedResult<BillingViewFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BillingViewFactory, T2, T3, T4, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3, T4>(this CombinedResult<T1, BillingViewFactory, T2, T3, T4> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BillingViewFactory, T3, T4, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3, T4>(this CombinedResult<T1, T2, BillingViewFactory, T3, T4> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BillingViewFactory, T4, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BillingViewFactory, T4> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BillingViewFactory, InnerBillingViewDataFilterExpressionFactory> WithDataFilterExpression<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BillingViewFactory> combinedResult, Action<Humidifier.Billing.BillingViewTypes.DataFilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataFilterExpression(combinedResult.T5, subFactoryAction).T2);
}
