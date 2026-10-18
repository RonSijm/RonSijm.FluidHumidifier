// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AIPromptVersionFactory(string resourceName = null, Action<Humidifier.Wisdom.AIPromptVersion> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AIPromptVersion>(resourceName)
{

    protected override Humidifier.Wisdom.AIPromptVersion Create()
    {
        var aIPromptVersionResult = CreateAIPromptVersion();
        factoryAction?.Invoke(aIPromptVersionResult);

        return aIPromptVersionResult;
    }

    private Humidifier.Wisdom.AIPromptVersion CreateAIPromptVersion()
    {
        var aIPromptVersionResult = new Humidifier.Wisdom.AIPromptVersion
        {
            GivenName = InputResourceName,
        };

        return aIPromptVersionResult;
    }

} // End Of Class

public static class AIPromptVersionFactoryExtensions
{
}
