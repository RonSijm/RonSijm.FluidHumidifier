// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisAnalysisSourceEntityFactory(Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity>
{

    internal InnerAnalysisAnalysisSourceTemplateFactory SourceTemplateFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity Create()
    {
        var analysisSourceEntityResult = CreateAnalysisSourceEntity();
        factoryAction?.Invoke(analysisSourceEntityResult);

        return analysisSourceEntityResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity CreateAnalysisSourceEntity()
    {
        var analysisSourceEntityResult = new Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity();

        return analysisSourceEntityResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity result)
    {
        base.CreateChildren(result);

        result.SourceTemplate ??= SourceTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisAnalysisSourceEntityFactoryExtensions
{
    public static CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate(this InnerAnalysisAnalysisSourceEntityFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null)
    {
        parentFactory.SourceTemplateFactory = new InnerAnalysisAnalysisSourceTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTemplateFactory);
    }

    public static CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2, T3, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2, T3, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory, T3, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisAnalysisSourceEntityFactory, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisAnalysisSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2, T3, T4, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisAnalysisSourceEntityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2, T3, T4, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisAnalysisSourceEntityFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory, T3, T4, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisAnalysisSourceEntityFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisAnalysisSourceEntityFactory, T4, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisAnalysisSourceEntityFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisAnalysisSourceEntityFactory, InnerAnalysisAnalysisSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisAnalysisSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T5, subFactoryAction));
}
