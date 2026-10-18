// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class HumanTaskUiFactory(string resourceName = null, Action<Humidifier.SageMaker.HumanTaskUi> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.HumanTaskUi>(resourceName)
{

    internal InnerHumanTaskUiUiTemplateFactory UiTemplateFactory { get; set; }

    protected override Humidifier.SageMaker.HumanTaskUi Create()
    {
        var humanTaskUiResult = CreateHumanTaskUi();
        factoryAction?.Invoke(humanTaskUiResult);

        return humanTaskUiResult;
    }

    private Humidifier.SageMaker.HumanTaskUi CreateHumanTaskUi()
    {
        var humanTaskUiResult = new Humidifier.SageMaker.HumanTaskUi
        {
            GivenName = InputResourceName,
        };

        return humanTaskUiResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.HumanTaskUi result)
    {
        base.CreateChildren(result);

        result.UiTemplate ??= UiTemplateFactory?.Build();
    }

} // End Of Class

public static class HumanTaskUiFactoryExtensions
{
    public static CombinedResult<HumanTaskUiFactory, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate(this HumanTaskUiFactory parentFactory, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null)
    {
        parentFactory.UiTemplateFactory = new InnerHumanTaskUiUiTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UiTemplateFactory);
    }

    public static CombinedResult<HumanTaskUiFactory, T1, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1>(this CombinedResult<HumanTaskUiFactory, T1> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithUiTemplate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HumanTaskUiFactory, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1>(this CombinedResult<T1, HumanTaskUiFactory> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithUiTemplate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<HumanTaskUiFactory, T1, T2, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2>(this CombinedResult<HumanTaskUiFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HumanTaskUiFactory, T2, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2>(this CombinedResult<T1, HumanTaskUiFactory, T2> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HumanTaskUiFactory, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2>(this CombinedResult<T1, T2, HumanTaskUiFactory> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<HumanTaskUiFactory, T1, T2, T3, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3>(this CombinedResult<HumanTaskUiFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HumanTaskUiFactory, T2, T3, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3>(this CombinedResult<T1, HumanTaskUiFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HumanTaskUiFactory, T3, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3>(this CombinedResult<T1, T2, HumanTaskUiFactory, T3> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HumanTaskUiFactory, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, HumanTaskUiFactory> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<HumanTaskUiFactory, T1, T2, T3, T4, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3, T4>(this CombinedResult<HumanTaskUiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HumanTaskUiFactory, T2, T3, T4, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3, T4>(this CombinedResult<T1, HumanTaskUiFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HumanTaskUiFactory, T3, T4, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, HumanTaskUiFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HumanTaskUiFactory, T4, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HumanTaskUiFactory, T4> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, HumanTaskUiFactory, InnerHumanTaskUiUiTemplateFactory> WithUiTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HumanTaskUiFactory> combinedResult, Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUiTemplate(combinedResult.T5, subFactoryAction).T2);
}
