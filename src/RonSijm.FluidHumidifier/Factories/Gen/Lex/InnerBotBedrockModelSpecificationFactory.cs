// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotBedrockModelSpecificationFactory(Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.BedrockModelSpecification>
{

    internal InnerBotBedrockGuardrailConfigurationFactory BedrockGuardrailConfigurationFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.BedrockModelSpecification Create()
    {
        var bedrockModelSpecificationResult = CreateBedrockModelSpecification();
        factoryAction?.Invoke(bedrockModelSpecificationResult);

        return bedrockModelSpecificationResult;
    }

    private Humidifier.Lex.BotTypes.BedrockModelSpecification CreateBedrockModelSpecification()
    {
        var bedrockModelSpecificationResult = new Humidifier.Lex.BotTypes.BedrockModelSpecification();

        return bedrockModelSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.BedrockModelSpecification result)
    {
        base.CreateChildren(result);

        result.BedrockGuardrailConfiguration ??= BedrockGuardrailConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerBotBedrockModelSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotBedrockModelSpecificationFactory, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration(this InnerBotBedrockModelSpecificationFactory parentFactory, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null)
    {
        parentFactory.BedrockGuardrailConfigurationFactory = new InnerBotBedrockGuardrailConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockGuardrailConfigurationFactory);
    }

    public static CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1>(this CombinedResult<InnerBotBedrockModelSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1>(this CombinedResult<T1, InnerBotBedrockModelSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2>(this CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2>(this CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2, T3, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3>(this CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2, T3, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory, T3, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotBedrockModelSpecificationFactory, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotBedrockModelSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2, T3, T4, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerBotBedrockModelSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2, T3, T4, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotBedrockModelSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory, T3, T4, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotBedrockModelSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotBedrockModelSpecificationFactory, T4, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotBedrockModelSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotBedrockModelSpecificationFactory, InnerBotBedrockGuardrailConfigurationFactory> WithBedrockGuardrailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockGuardrailConfiguration(combinedResult.T5, subFactoryAction).T2);
}
