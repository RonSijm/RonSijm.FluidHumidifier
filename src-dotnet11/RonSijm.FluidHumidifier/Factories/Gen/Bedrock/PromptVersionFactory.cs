// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class PromptVersionFactory(string resourceName = null, Action<Humidifier.Bedrock.PromptVersion> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.PromptVersion>(resourceName)
{

    protected override Humidifier.Bedrock.PromptVersion Create()
    {
        var promptVersionResult = CreatePromptVersion();
        factoryAction?.Invoke(promptVersionResult);

        return promptVersionResult;
    }

    private Humidifier.Bedrock.PromptVersion CreatePromptVersion()
    {
        var promptVersionResult = new Humidifier.Bedrock.PromptVersion
        {
            GivenName = InputResourceName,
        };

        return promptVersionResult;
    }

} // End Of Class

public static class PromptVersionFactoryExtensions
{
}
