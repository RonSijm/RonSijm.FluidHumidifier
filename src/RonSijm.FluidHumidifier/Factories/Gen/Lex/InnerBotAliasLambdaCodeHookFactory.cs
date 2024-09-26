// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasLambdaCodeHookFactory(Action<Humidifier.Lex.BotAliasTypes.LambdaCodeHook> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.LambdaCodeHook>
{

    protected override Humidifier.Lex.BotAliasTypes.LambdaCodeHook Create()
    {
        var lambdaCodeHookResult = CreateLambdaCodeHook();
        factoryAction?.Invoke(lambdaCodeHookResult);

        return lambdaCodeHookResult;
    }

    private Humidifier.Lex.BotAliasTypes.LambdaCodeHook CreateLambdaCodeHook()
    {
        var lambdaCodeHookResult = new Humidifier.Lex.BotAliasTypes.LambdaCodeHook();

        return lambdaCodeHookResult;
    }

} // End Of Class

public static class InnerBotAliasLambdaCodeHookFactoryExtensions
{
}
