// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSlotResolutionImprovementSpecificationFactory(Action<Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification>
{

    internal InnerBotBedrockModelSpecificationFactory BedrockModelSpecificationFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification Create()
    {
        var slotResolutionImprovementSpecificationResult = CreateSlotResolutionImprovementSpecification();
        factoryAction?.Invoke(slotResolutionImprovementSpecificationResult);

        return slotResolutionImprovementSpecificationResult;
    }

    private Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification CreateSlotResolutionImprovementSpecification()
    {
        var slotResolutionImprovementSpecificationResult = new Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification();

        return slotResolutionImprovementSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification result)
    {
        base.CreateChildren(result);

        result.BedrockModelSpecification ??= BedrockModelSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerBotSlotResolutionImprovementSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification(this InnerBotSlotResolutionImprovementSpecificationFactory parentFactory, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null)
    {
        parentFactory.BedrockModelSpecificationFactory = new InnerBotBedrockModelSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockModelSpecificationFactory);
    }

    public static CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1>(this CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2>(this CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory, T3, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSlotResolutionImprovementSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotSlotResolutionImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<InnerBotSlotResolutionImprovementSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotSlotResolutionImprovementSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory, T3, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotSlotResolutionImprovementSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSlotResolutionImprovementSpecificationFactory, T4, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotSlotResolutionImprovementSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotSlotResolutionImprovementSpecificationFactory, InnerBotBedrockModelSpecificationFactory> WithBedrockModelSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotSlotResolutionImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BedrockModelSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockModelSpecification(combinedResult.T5, subFactoryAction).T2);
}
