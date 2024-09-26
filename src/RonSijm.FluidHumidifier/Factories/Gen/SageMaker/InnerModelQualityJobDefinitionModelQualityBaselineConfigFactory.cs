// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig>
{

    internal InnerModelQualityJobDefinitionConstraintsResourceFactory ConstraintsResourceFactory { get; set; }

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig Create()
    {
        var modelQualityBaselineConfigResult = CreateModelQualityBaselineConfig();
        factoryAction?.Invoke(modelQualityBaselineConfigResult);

        return modelQualityBaselineConfigResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig CreateModelQualityBaselineConfig()
    {
        var modelQualityBaselineConfigResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig();

        return modelQualityBaselineConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig result)
    {
        base.CreateChildren(result);

        result.ConstraintsResource ??= ConstraintsResourceFactory?.Build();
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionModelQualityBaselineConfigFactoryExtensions
{
    public static CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource(this InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null)
    {
        parentFactory.ConstraintsResourceFactory = new InnerModelQualityJobDefinitionConstraintsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsResourceFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2, T3, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2, T3, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T3, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2, T3, T4, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T3, T4, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T4, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory, InnerModelQualityJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionModelQualityBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T5, subFactoryAction));
}
