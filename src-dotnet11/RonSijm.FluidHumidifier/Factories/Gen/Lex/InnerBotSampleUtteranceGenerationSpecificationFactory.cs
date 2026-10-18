// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSampleUtteranceGenerationSpecificationFactory(Action<Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification>
{

    internal InnerBotBedrockModelSpecificationFactory BedrockModelSpecificationFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification Create()
    {
        var sampleUtteranceGenerationSpecificationResult = CreateSampleUtteranceGenerationSpecification();
        factoryAction?.Invoke(sampleUtteranceGenerationSpecificationResult);

        return sampleUtteranceGenerationSpecificationResult;
    }

    private Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification CreateSampleUtteranceGenerationSpecification()
    {
        var sampleUtteranceGenerationSpecificationResult = new Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification();

        return sampleUtteranceGenerationSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification result)
    {
        base.CreateChildren(result);

        result.BedrockModelSpecification ??= BedrockModelSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerBotSampleUtteranceGenerationSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification(this InnerBotSampleUtteranceGenerationSpecificationFactory parentFactory, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null)
    {
        parentFactory.BedrockModelSpecificationFactory = new InnerBotBedrockModelSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockModelSpecificationFactory);
    }

    public static CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSampleUtteranceGenerationSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotSampleUtteranceGenerationSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<InnerBotSampleUtteranceGenerationSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotSampleUtteranceGenerationSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotSampleUtteranceGenerationSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSampleUtteranceGenerationSpecificationFactory, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotSampleUtteranceGenerationSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotSampleUtteranceGenerationSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotSampleUtteranceGenerationSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T5, subFactoryAction).T2);
}
