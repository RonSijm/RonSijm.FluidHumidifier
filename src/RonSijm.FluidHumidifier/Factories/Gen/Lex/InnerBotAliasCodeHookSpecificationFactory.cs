// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasCodeHookSpecificationFactory(Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.CodeHookSpecification>
{

    internal InnerBotAliasLambdaCodeHookFactory LambdaCodeHookFactory { get; set; }

    protected override Humidifier.Lex.BotAliasTypes.CodeHookSpecification Create()
    {
        var codeHookSpecificationResult = CreateCodeHookSpecification();
        factoryAction?.Invoke(codeHookSpecificationResult);

        return codeHookSpecificationResult;
    }

    private Humidifier.Lex.BotAliasTypes.CodeHookSpecification CreateCodeHookSpecification()
    {
        var codeHookSpecificationResult = new Humidifier.Lex.BotAliasTypes.CodeHookSpecification();

        return codeHookSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotAliasTypes.CodeHookSpecification result)
    {
        base.CreateChildren(result);

        result.LambdaCodeHook ??= LambdaCodeHookFactory?.Build();
    }

} // End Of Class

public static class InnerBotAliasCodeHookSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotAliasCodeHookSpecificationFactory, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook(this InnerBotAliasCodeHookSpecificationFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null)
    {
        parentFactory.LambdaCodeHookFactory = new InnerBotAliasLambdaCodeHookFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaCodeHookFactory);
    }

    public static CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1>(this CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1>(this CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2>(this CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2>(this CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2>(this CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2, T3, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3>(this CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2, T3, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3>(this CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory, T3, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasCodeHookSpecificationFactory, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotAliasCodeHookSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2, T3, T4, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3, T4>(this CombinedResult<InnerBotAliasCodeHookSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2, T3, T4, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotAliasCodeHookSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory, T3, T4, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotAliasCodeHookSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasCodeHookSpecificationFactory, T4, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotAliasCodeHookSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotAliasCodeHookSpecificationFactory, InnerBotAliasLambdaCodeHookFactory> WithLambdaCodeHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotAliasCodeHookSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaCodeHook(combinedResult.T5, subFactoryAction));
}
