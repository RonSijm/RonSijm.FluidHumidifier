// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDashboardSourceEntityFactory(Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity>
{

    internal InnerDashboardDashboardSourceTemplateFactory SourceTemplateFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity Create()
    {
        var dashboardSourceEntityResult = CreateDashboardSourceEntity();
        factoryAction?.Invoke(dashboardSourceEntityResult);

        return dashboardSourceEntityResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity CreateDashboardSourceEntity()
    {
        var dashboardSourceEntityResult = new Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity();

        return dashboardSourceEntityResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity result)
    {
        base.CreateChildren(result);

        result.SourceTemplate ??= SourceTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDashboardSourceEntityFactoryExtensions
{
    public static CombinedResult<InnerDashboardDashboardSourceEntityFactory, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate(this InnerDashboardDashboardSourceEntityFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null)
    {
        parentFactory.SourceTemplateFactory = new InnerDashboardDashboardSourceTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTemplateFactory);
    }

    public static CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2, T3, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2, T3, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory, T3, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardSourceEntityFactory, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2, T3, T4, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDashboardSourceEntityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2, T3, T4, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDashboardSourceEntityFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory, T3, T4, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDashboardSourceEntityFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardSourceEntityFactory, T4, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardSourceEntityFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardSourceEntityFactory, InnerDashboardDashboardSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T5, subFactoryAction));
}
