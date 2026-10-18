// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerLayoutBasicLayoutFactory(Action<Humidifier.Cases.LayoutTypes.BasicLayout> factoryAction = null) : SubResourceFactory<Humidifier.Cases.LayoutTypes.BasicLayout>
{

    internal InnerLayoutLayoutSectionsFactory TopPanelFactory { get; set; }

    internal InnerLayoutLayoutSectionsFactory MoreInfoFactory { get; set; }

    protected override Humidifier.Cases.LayoutTypes.BasicLayout Create()
    {
        var basicLayoutResult = CreateBasicLayout();
        factoryAction?.Invoke(basicLayoutResult);

        return basicLayoutResult;
    }

    private Humidifier.Cases.LayoutTypes.BasicLayout CreateBasicLayout()
    {
        var basicLayoutResult = new Humidifier.Cases.LayoutTypes.BasicLayout();

        return basicLayoutResult;
    }
    public override void CreateChildren(Humidifier.Cases.LayoutTypes.BasicLayout result)
    {
        base.CreateChildren(result);

        result.TopPanel ??= TopPanelFactory?.Build();
        result.MoreInfo ??= MoreInfoFactory?.Build();
    }

} // End Of Class

public static class InnerLayoutBasicLayoutFactoryExtensions
{
    public static CombinedResult<InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithTopPanel(this InnerLayoutBasicLayoutFactory parentFactory, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null)
    {
        parentFactory.TopPanelFactory = new InnerLayoutLayoutSectionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TopPanelFactory);
    }

    public static CombinedResult<InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithMoreInfo(this InnerLayoutBasicLayoutFactory parentFactory, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null)
    {
        parentFactory.MoreInfoFactory = new InnerLayoutLayoutSectionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MoreInfoFactory);
    }

    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopPanel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopPanel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, T4, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3, T4>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, T4, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, T4, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, T4, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithTopPanel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopPanel(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, WithMoreInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, WithMoreInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, T4, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3, T4>(this CombinedResult<InnerLayoutBasicLayoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, T4, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayoutBasicLayoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, T4, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayoutBasicLayoutFactory, T3, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, T4, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayoutBasicLayoutFactory, T4> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLayoutBasicLayoutFactory, InnerLayoutLayoutSectionsFactory> WithMoreInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayoutBasicLayoutFactory> combinedResult, Action<Humidifier.Cases.LayoutTypes.LayoutSections> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMoreInfo(combinedResult.T5, subFactoryAction).T2);
}
