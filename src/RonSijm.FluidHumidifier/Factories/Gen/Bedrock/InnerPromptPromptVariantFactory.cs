// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptVariantFactory(Action<Humidifier.Bedrock.PromptTypes.PromptVariant> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptVariant>
{

    internal InnerPromptPromptInferenceConfigurationFactory InferenceConfigurationFactory { get; set; }

    internal InnerPromptPromptTemplateConfigurationFactory TemplateConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.PromptVariant Create()
    {
        var promptVariantResult = CreatePromptVariant();
        factoryAction?.Invoke(promptVariantResult);

        return promptVariantResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptVariant CreatePromptVariant()
    {
        var promptVariantResult = new Humidifier.Bedrock.PromptTypes.PromptVariant();

        return promptVariantResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.PromptVariant result)
    {
        base.CreateChildren(result);

        result.InferenceConfiguration ??= InferenceConfigurationFactory?.Build();
        result.TemplateConfiguration ??= TemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPromptPromptVariantFactoryExtensions
{
    public static CombinedResult<InnerPromptPromptVariantFactory, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration(this InnerPromptPromptVariantFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null)
    {
        parentFactory.InferenceConfigurationFactory = new InnerPromptPromptInferenceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceConfigurationFactory);
    }

    public static CombinedResult<InnerPromptPromptVariantFactory, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration(this InnerPromptPromptVariantFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TemplateConfigurationFactory = new InnerPromptPromptTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateConfigurationFactory);
    }

    public static CombinedResult<InnerPromptPromptVariantFactory, T1, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1>(this CombinedResult<InnerPromptPromptVariantFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1>(this CombinedResult<T1, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, T4, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, T4, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, T4, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, T4, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptPromptVariantFactory, InnerPromptPromptInferenceConfigurationFactory> WithInferenceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<InnerPromptPromptVariantFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<T1, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, T4, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPromptPromptVariantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, T4, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptPromptVariantFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, T4, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptPromptVariantFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, T4, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptPromptVariantFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptPromptVariantFactory, InnerPromptPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptPromptVariantFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T5, subFactoryAction));
}
