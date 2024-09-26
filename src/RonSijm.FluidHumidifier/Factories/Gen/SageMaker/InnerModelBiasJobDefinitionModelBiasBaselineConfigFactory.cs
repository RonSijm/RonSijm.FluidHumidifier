// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig>
{

    internal InnerModelBiasJobDefinitionConstraintsResourceFactory ConstraintsResourceFactory { get; set; }

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig Create()
    {
        var modelBiasBaselineConfigResult = CreateModelBiasBaselineConfig();
        factoryAction?.Invoke(modelBiasBaselineConfigResult);

        return modelBiasBaselineConfigResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig CreateModelBiasBaselineConfig()
    {
        var modelBiasBaselineConfigResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig();

        return modelBiasBaselineConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasBaselineConfig result)
    {
        base.CreateChildren(result);

        result.ConstraintsResource ??= ConstraintsResourceFactory?.Build();
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionModelBiasBaselineConfigFactoryExtensions
{
    public static CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource(this InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null)
    {
        parentFactory.ConstraintsResourceFactory = new InnerModelBiasJobDefinitionConstraintsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsResourceFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2, T3, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2, T3, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T3, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2, T3, T4, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T3, T4, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T4, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory, InnerModelBiasJobDefinitionConstraintsResourceFactory> WithConstraintsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionModelBiasBaselineConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraintsResource(combinedResult.T5, subFactoryAction));
}
