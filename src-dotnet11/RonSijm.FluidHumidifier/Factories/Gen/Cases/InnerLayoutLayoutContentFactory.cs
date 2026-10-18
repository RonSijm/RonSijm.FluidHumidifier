// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerLayoutLayoutContentFactory(Action<Humidifier.Cases.LayoutTypes.LayoutContent> factoryAction = null) : SubResourceFactory<Humidifier.Cases.LayoutTypes.LayoutContent>
{

    internal InnerLayoutBasicLayoutFactory BasicFactory { get; set; }

    protected override Humidifier.Cases.LayoutTypes.LayoutContent Create()
    {
        var layoutContentResult = CreateLayoutContent();
        factoryAction?.Invoke(layoutContentResult);

        return layoutContentResult;
    }

    private Humidifier.Cases.LayoutTypes.LayoutContent CreateLayoutContent()
    {
        var layoutContentResult = new Humidifier.Cases.LayoutTypes.LayoutContent();

        return layoutContentResult;
    }
    public override void CreateChildren(Humidifier.Cases.LayoutTypes.LayoutContent result)
    {
        base.CreateChildren(result);

        result.Basic ??= BasicFactory?.Build();
    }

} // End Of Class

public static class InnerLayoutLayoutContentFactoryExtensions
{
    public static CombinedResult<InnerLayoutLayoutContentFactory, InnerLayoutBasicLayoutFactory> WithBasic(this InnerLayoutLayoutContentFactory parentFactory, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null)
    {
        parentFactory.BasicFactory = new InnerLayoutBasicLayoutFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BasicFactory);
    }

    public static CombinedResult<InnerLayoutLayoutContentFactory, T1, InnerLayoutBasicLayoutFactory> WithBasic<T1>(this CombinedResult<InnerLayoutLayoutContentFactory, T1> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutLayoutContentFactory, InnerLayoutBasicLayoutFactory> WithBasic<T1>(this CombinedResult<T1, InnerLayoutLayoutContentFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutLayoutContentFactory, T1, T2, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2>(this CombinedResult<InnerLayoutLayoutContentFactory, T1, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutLayoutContentFactory, T2, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2>(this CombinedResult<T1, InnerLayoutLayoutContentFactory, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutLayoutContentFactory, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2>(this CombinedResult<T1, T2, InnerLayoutLayoutContentFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutLayoutContentFactory, T1, T2, T3, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3>(this CombinedResult<InnerLayoutLayoutContentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutLayoutContentFactory, T2, T3, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3>(this CombinedResult<T1, InnerLayoutLayoutContentFactory, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutLayoutContentFactory, T3, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayoutLayoutContentFactory, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutLayoutContentFactory, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayoutLayoutContentFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutLayoutContentFactory, T1, T2, T3, T4, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3, T4>(this CombinedResult<InnerLayoutLayoutContentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutLayoutContentFactory, T2, T3, T4, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayoutLayoutContentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutLayoutContentFactory, T3, T4, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayoutLayoutContentFactory, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutLayoutContentFactory, T4, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayoutLayoutContentFactory, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLayoutLayoutContentFactory, InnerLayoutBasicLayoutFactory> WithBasic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayoutLayoutContentFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.BasicLayout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasic(combinedResult.T5, subFactoryAction).T2);
}
