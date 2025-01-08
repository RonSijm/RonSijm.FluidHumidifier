// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AIGuardrailVersionFactory(string resourceName = null, Action<Humidifier.Wisdom.AIGuardrailVersion> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AIGuardrailVersion>(resourceName)
{

    protected override Humidifier.Wisdom.AIGuardrailVersion Create()
    {
        var aIGuardrailVersionResult = CreateAIGuardrailVersion();
        factoryAction?.Invoke(aIGuardrailVersionResult);

        return aIGuardrailVersionResult;
    }

    private Humidifier.Wisdom.AIGuardrailVersion CreateAIGuardrailVersion()
    {
        var aIGuardrailVersionResult = new Humidifier.Wisdom.AIGuardrailVersion
        {
            GivenName = InputResourceName,
        };

        return aIGuardrailVersionResult;
    }

} // End Of Class

public static class AIGuardrailVersionFactoryExtensions
{
}
