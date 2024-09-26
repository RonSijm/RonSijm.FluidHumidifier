// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormEvaluationFormBaseItemFactory(Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem>
{

    internal InnerEvaluationFormEvaluationFormSectionFactory SectionFactory { get; set; }

    protected override Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem Create()
    {
        var evaluationFormBaseItemResult = CreateEvaluationFormBaseItem();
        factoryAction?.Invoke(evaluationFormBaseItemResult);

        return evaluationFormBaseItemResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem CreateEvaluationFormBaseItem()
    {
        var evaluationFormBaseItemResult = new Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem();

        return evaluationFormBaseItemResult;
    }
    public override void CreateChildren(Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem result)
    {
        base.CreateChildren(result);

        result.Section ??= SectionFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluationFormEvaluationFormBaseItemFactoryExtensions
{
    public static CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, InnerEvaluationFormEvaluationFormSectionFactory> WithSection(this InnerEvaluationFormEvaluationFormBaseItemFactory parentFactory, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null)
    {
        parentFactory.SectionFactory = new InnerEvaluationFormEvaluationFormSectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SectionFactory);
    }

    public static CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1>(this CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, WithSection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1>(this CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, WithSection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2>(this CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2>(this CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2>(this CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2, T3, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3>(this CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2, T3, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3>(this CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory, T3, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2, T3, T4, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3, T4>(this CombinedResult<InnerEvaluationFormEvaluationFormBaseItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2, T3, T4, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluationFormEvaluationFormBaseItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory, T3, T4, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory, T4, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluationFormEvaluationFormBaseItemFactory, InnerEvaluationFormEvaluationFormSectionFactory> WithSection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluationFormEvaluationFormBaseItemFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSection(combinedResult.T5, subFactoryAction));
}
