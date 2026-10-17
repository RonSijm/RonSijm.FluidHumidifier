// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotDescriptiveBotBuilderSpecificationFactory(Action<Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification>
{

    internal InnerBotBedrockModelSpecificationFactory BedrockModelSpecificationFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification Create()
    {
        var descriptiveBotBuilderSpecificationResult = CreateDescriptiveBotBuilderSpecification();
        factoryAction?.Invoke(descriptiveBotBuilderSpecificationResult);

        return descriptiveBotBuilderSpecificationResult;
    }

    private Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification CreateDescriptiveBotBuilderSpecification()
    {
        var descriptiveBotBuilderSpecificationResult = new Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification();

        return descriptiveBotBuilderSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification result)
    {
        base.CreateChildren(result);

        result.BedrockModelSpecification ??= BedrockModelSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerBotDescriptiveBotBuilderSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification(this InnerBotDescriptiveBotBuilderSpecificationFactory parentFactory, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null)
    {
        parentFactory.BedrockModelSpecificationFactory = new InnerBotBedrockModelSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockModelSpecificationFactory);
    }

    public static CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotDescriptiveBotBuilderSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotDescriptiveBotBuilderSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<InnerBotDescriptiveBotBuilderSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotDescriptiveBotBuilderSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotDescriptiveBotBuilderSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotDescriptiveBotBuilderSpecificationFactory, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotDescriptiveBotBuilderSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotDescriptiveBotBuilderSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotDescriptiveBotBuilderSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T5, subFactoryAction).T2);
}
