// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateTemplateSourceEntityFactory(Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity>
{

    internal InnerTemplateTemplateSourceAnalysisFactory SourceAnalysisFactory { get; set; }

    internal InnerTemplateTemplateSourceTemplateFactory SourceTemplateFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity Create()
    {
        var templateSourceEntityResult = CreateTemplateSourceEntity();
        factoryAction?.Invoke(templateSourceEntityResult);

        return templateSourceEntityResult;
    }

    private Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity CreateTemplateSourceEntity()
    {
        var templateSourceEntityResult = new Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity();

        return templateSourceEntityResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity result)
    {
        base.CreateChildren(result);

        result.SourceAnalysis ??= SourceAnalysisFactory?.Build();
        result.SourceTemplate ??= SourceTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateTemplateSourceEntityFactoryExtensions
{
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis(this InnerTemplateTemplateSourceEntityFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null)
    {
        parentFactory.SourceAnalysisFactory = new InnerTemplateTemplateSourceAnalysisFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceAnalysisFactory);
    }

    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate(this InnerTemplateTemplateSourceEntityFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null)
    {
        parentFactory.SourceTemplateFactory = new InnerTemplateTemplateSourceTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTemplateFactory);
    }

    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, T4, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3, T4>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, T4, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, T4, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, T4, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceAnalysisFactory> WithSourceAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceAnalysis(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, T4, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<InnerTemplateTemplateSourceEntityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, T4, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateTemplateSourceEntityFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, T4, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateTemplateSourceEntityFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, T4, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateTemplateSourceEntityFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateTemplateSourceEntityFactory, InnerTemplateTemplateSourceTemplateFactory> WithSourceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateTemplateSourceEntityFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTemplate(combinedResult.T5, subFactoryAction));
}
