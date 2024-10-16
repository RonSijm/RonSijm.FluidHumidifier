// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotVersionBotVersionLocaleSpecificationFactory(Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification>
{

    internal InnerBotVersionBotVersionLocaleDetailsFactory BotVersionLocaleDetailsFactory { get; set; }

    protected override Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification Create()
    {
        var botVersionLocaleSpecificationResult = CreateBotVersionLocaleSpecification();
        factoryAction?.Invoke(botVersionLocaleSpecificationResult);

        return botVersionLocaleSpecificationResult;
    }

    private Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification CreateBotVersionLocaleSpecification()
    {
        var botVersionLocaleSpecificationResult = new Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification();

        return botVersionLocaleSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification result)
    {
        base.CreateChildren(result);

        result.BotVersionLocaleDetails ??= BotVersionLocaleDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerBotVersionBotVersionLocaleSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails(this InnerBotVersionBotVersionLocaleSpecificationFactory parentFactory, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null)
    {
        parentFactory.BotVersionLocaleDetailsFactory = new InnerBotVersionBotVersionLocaleDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BotVersionLocaleDetailsFactory);
    }

    public static CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1>(this CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1>(this CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2>(this CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2>(this CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2>(this CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2, T3, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3>(this CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2, T3, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3>(this CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory, T3, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2, T3, T4, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3, T4>(this CombinedResult<InnerBotVersionBotVersionLocaleSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2, T3, T4, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotVersionBotVersionLocaleSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory, T3, T4, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory, T4, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotVersionBotVersionLocaleSpecificationFactory, InnerBotVersionBotVersionLocaleDetailsFactory> WithBotVersionLocaleDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotVersionBotVersionLocaleSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleDetails(combinedResult.T5, subFactoryAction));
}
