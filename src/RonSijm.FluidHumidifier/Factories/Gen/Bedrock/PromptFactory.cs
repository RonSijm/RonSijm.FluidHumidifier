// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class PromptFactory(string resourceName = null, Action<Humidifier.Bedrock.Prompt> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.Prompt>(resourceName)
{

    internal List<InnerPromptPromptVariantFactory> VariantsFactories { get; set; } = [];

    protected override Humidifier.Bedrock.Prompt Create()
    {
        var promptResult = CreatePrompt();
        factoryAction?.Invoke(promptResult);

        return promptResult;
    }

    private Humidifier.Bedrock.Prompt CreatePrompt()
    {
        var promptResult = new Humidifier.Bedrock.Prompt
        {
            GivenName = InputResourceName,
        };

        return promptResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.Prompt result)
    {
        base.CreateChildren(result);

        result.Variants = VariantsFactories.Any() ? VariantsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PromptFactoryExtensions
{
    public static CombinedResult<PromptFactory, InnerPromptPromptVariantFactory> WithVariants(this PromptFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null)
    {
        var factory = new InnerPromptPromptVariantFactory(subFactoryAction);
        parentFactory.VariantsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PromptFactory, T1, InnerPromptPromptVariantFactory> WithVariants<T1>(this CombinedResult<PromptFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PromptFactory, InnerPromptPromptVariantFactory> WithVariants<T1>(this CombinedResult<T1, PromptFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PromptFactory, T1, T2, InnerPromptPromptVariantFactory> WithVariants<T1, T2>(this CombinedResult<PromptFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PromptFactory, T2, InnerPromptPromptVariantFactory> WithVariants<T1, T2>(this CombinedResult<T1, PromptFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PromptFactory, InnerPromptPromptVariantFactory> WithVariants<T1, T2>(this CombinedResult<T1, T2, PromptFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PromptFactory, T1, T2, T3, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<PromptFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PromptFactory, T2, T3, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, PromptFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PromptFactory, T3, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, T2, PromptFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PromptFactory, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, T2, T3, PromptFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PromptFactory, T1, T2, T3, T4, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<PromptFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PromptFactory, T2, T3, T4, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, PromptFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PromptFactory, T3, T4, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, PromptFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PromptFactory, T4, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PromptFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PromptFactory, InnerPromptPromptVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PromptFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T5, subFactoryAction));
}
