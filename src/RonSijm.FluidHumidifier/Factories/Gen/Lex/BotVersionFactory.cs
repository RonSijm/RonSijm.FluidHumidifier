// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class BotVersionFactory(string resourceName = null, Action<Humidifier.Lex.BotVersion> factoryAction = null) : ResourceFactory<Humidifier.Lex.BotVersion>(resourceName)
{

    internal List<InnerBotVersionBotVersionLocaleSpecificationFactory> BotVersionLocaleSpecificationFactories { get; set; } = [];

    protected override Humidifier.Lex.BotVersion Create()
    {
        var botVersionResult = CreateBotVersion();
        factoryAction?.Invoke(botVersionResult);

        return botVersionResult;
    }

    private Humidifier.Lex.BotVersion CreateBotVersion()
    {
        var botVersionResult = new Humidifier.Lex.BotVersion
        {
            GivenName = InputResourceName,
        };

        return botVersionResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotVersion result)
    {
        base.CreateChildren(result);

        result.BotVersionLocaleSpecification = BotVersionLocaleSpecificationFactories.Any() ? BotVersionLocaleSpecificationFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class BotVersionFactoryExtensions
{
    public static CombinedResult<BotVersionFactory, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification(this BotVersionFactory parentFactory, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null)
    {
        var factory = new InnerBotVersionBotVersionLocaleSpecificationFactory(subFactoryAction);
        parentFactory.BotVersionLocaleSpecificationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BotVersionFactory, T1, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1>(this CombinedResult<BotVersionFactory, T1> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotVersionFactory, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1>(this CombinedResult<T1, BotVersionFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotVersionFactory, T1, T2, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2>(this CombinedResult<BotVersionFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotVersionFactory, T2, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2>(this CombinedResult<T1, BotVersionFactory, T2> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotVersionFactory, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2>(this CombinedResult<T1, T2, BotVersionFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotVersionFactory, T1, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3>(this CombinedResult<BotVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotVersionFactory, T2, T3, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3>(this CombinedResult<T1, BotVersionFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotVersionFactory, T3, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3>(this CombinedResult<T1, T2, BotVersionFactory, T3> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotVersionFactory, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotVersionFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotVersionFactory, T1, T2, T3, T4, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3, T4>(this CombinedResult<BotVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotVersionFactory, T2, T3, T4, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3, T4>(this CombinedResult<T1, BotVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotVersionFactory, T3, T4, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotVersionFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotVersionFactory, T4, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotVersionFactory, T4> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotVersionFactory, InnerBotVersionBotVersionLocaleSpecificationFactory> WithBotVersionLocaleSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotVersionFactory> combinedResult, Action<Humidifier.Lex.BotVersionTypes.BotVersionLocaleSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotVersionLocaleSpecification(combinedResult.T5, subFactoryAction));
}
