// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class DefaultPromptRouterFactory(string resourceName = null, Action<Humidifier.Bedrock.DefaultPromptRouter> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.DefaultPromptRouter>(resourceName)
{

    protected override Humidifier.Bedrock.DefaultPromptRouter Create()
    {
        var defaultPromptRouterResult = CreateDefaultPromptRouter();
        factoryAction?.Invoke(defaultPromptRouterResult);

        return defaultPromptRouterResult;
    }

    private Humidifier.Bedrock.DefaultPromptRouter CreateDefaultPromptRouter()
    {
        var defaultPromptRouterResult = new Humidifier.Bedrock.DefaultPromptRouter
        {
            GivenName = InputResourceName,
        };

        return defaultPromptRouterResult;
    }

} // End Of Class

public static class DefaultPromptRouterFactoryExtensions
{
}
