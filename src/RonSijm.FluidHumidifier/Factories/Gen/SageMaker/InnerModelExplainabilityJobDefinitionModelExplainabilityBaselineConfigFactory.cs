// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig>
{

    internal InnerModelExplainabilityJobDefinitionConstraintsResourceFactory ConstraintsResourceFactory { get; set; }

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig Create()
    {
        var modelExplainabilityBaselineConfigResult = CreateModelExplainabilityBaselineConfig();
        factoryAction?.Invoke(modelExplainabilityBaselineConfigResult);

        return modelExplainabilityBaselineConfigResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig CreateModelExplainabilityBaselineConfig()
    {
        var modelExplainabilityBaselineConfigResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig();

        return modelExplainabilityBaselineConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig result)
    {
        base.CreateChildren(result);

        result.ConstraintsResource ??= ConstraintsResourceFactory?.Build();
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactoryExtensions
{
    public static CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource(this InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null)
    {
        parentFactory.ConstraintsResourceFactory = new InnerModelExplainabilityJobDefinitionConstraintsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsResourceFactory);
    }

    public static CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2, T3, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2, T3, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T3, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2, T3, T4, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T3, T4, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T4, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory, InnerModelExplainabilityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionModelExplainabilityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T5, subFactoryAction));
}
