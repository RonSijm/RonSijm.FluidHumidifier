// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class LayoutFactory(string resourceName = null, Action<Humidifier.Cases.Layout> factoryAction = null) : ResourceFactory<Humidifier.Cases.Layout>(resourceName)
{

    internal InnerLayoutLayoutContentFactory ContentFactory { get; set; }

    protected override Humidifier.Cases.Layout Create()
    {
        var layoutResult = CreateLayout();
        factoryAction?.Invoke(layoutResult);

        return layoutResult;
    }

    private Humidifier.Cases.Layout CreateLayout()
    {
        var layoutResult = new Humidifier.Cases.Layout
        {
            GivenName = InputResourceName,
        };

        return layoutResult;
    }
    public override void CreateChildren(Humidifier.Cases.Layout result)
    {
        base.CreateChildren(result);

        result.Content ??= ContentFactory?.Build();
    }

} // End Of Class

public static class LayoutFactoryExtensions
{
    public static CombinedResult<LayoutFactory, InnerLayoutLayoutContentFactory> WithContent(this LayoutFactory parentFactory, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerLayoutLayoutContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<LayoutFactory, T1, InnerLayoutLayoutContentFactory> WithContent<T1>(this CombinedResult<LayoutFactory, T1> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LayoutFactory, InnerLayoutLayoutContentFactory> WithContent<T1>(this CombinedResult<T1, LayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LayoutFactory, T1, T2, InnerLayoutLayoutContentFactory> WithContent<T1, T2>(this CombinedResult<LayoutFactory, T1, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LayoutFactory, T2, InnerLayoutLayoutContentFactory> WithContent<T1, T2>(this CombinedResult<T1, LayoutFactory, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LayoutFactory, InnerLayoutLayoutContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, LayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LayoutFactory, T1, T2, T3, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3>(this CombinedResult<LayoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LayoutFactory, T2, T3, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, LayoutFactory, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LayoutFactory, T3, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, LayoutFactory, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LayoutFactory, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, LayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LayoutFactory, T1, T2, T3, T4, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<LayoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LayoutFactory, T2, T3, T4, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, LayoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LayoutFactory, T3, T4, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, LayoutFactory, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LayoutFactory, T4, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LayoutFactory, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LayoutFactory, InnerLayoutLayoutContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction).T2);
}
