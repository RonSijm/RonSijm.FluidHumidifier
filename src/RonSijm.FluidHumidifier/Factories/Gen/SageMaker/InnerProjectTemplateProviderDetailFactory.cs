// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProjectTemplateProviderDetailFactory(Action<Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail>
{

    internal InnerProjectCfnTemplateProviderDetailFactory CfnTemplateProviderDetailFactory { get; set; }

    protected override Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail Create()
    {
        var templateProviderDetailResult = CreateTemplateProviderDetail();
        factoryAction?.Invoke(templateProviderDetailResult);

        return templateProviderDetailResult;
    }

    private Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail CreateTemplateProviderDetail()
    {
        var templateProviderDetailResult = new Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail();

        return templateProviderDetailResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail result)
    {
        base.CreateChildren(result);

        result.CfnTemplateProviderDetail ??= CfnTemplateProviderDetailFactory?.Build();
    }

} // End Of Class

public static class InnerProjectTemplateProviderDetailFactoryExtensions
{
    public static CombinedResult<InnerProjectTemplateProviderDetailFactory, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail(this InnerProjectTemplateProviderDetailFactory parentFactory, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null)
    {
        parentFactory.CfnTemplateProviderDetailFactory = new InnerProjectCfnTemplateProviderDetailFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CfnTemplateProviderDetailFactory);
    }

    public static CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1>(this CombinedResult<InnerProjectTemplateProviderDetailFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1>(this CombinedResult<T1, InnerProjectTemplateProviderDetailFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2>(this CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2>(this CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2>(this CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2, T3, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3>(this CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2, T3, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3>(this CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory, T3, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectTemplateProviderDetailFactory, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectTemplateProviderDetailFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2, T3, T4, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3, T4>(this CombinedResult<InnerProjectTemplateProviderDetailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2, T3, T4, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectTemplateProviderDetailFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory, T3, T4, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectTemplateProviderDetailFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectTemplateProviderDetailFactory, T4, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectTemplateProviderDetailFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProjectTemplateProviderDetailFactory, InnerProjectCfnTemplateProviderDetailFactory> WithCfnTemplateProviderDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectTemplateProviderDetailFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCfnTemplateProviderDetail(combinedResult.T5, subFactoryAction).T2);
}
