// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class GuardrailVersionFactory(string resourceName = null, Action<Humidifier.Bedrock.GuardrailVersion> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.GuardrailVersion>(resourceName)
{

    protected override Humidifier.Bedrock.GuardrailVersion Create()
    {
        var guardrailVersionResult = CreateGuardrailVersion();
        factoryAction?.Invoke(guardrailVersionResult);

        return guardrailVersionResult;
    }

    private Humidifier.Bedrock.GuardrailVersion CreateGuardrailVersion()
    {
        var guardrailVersionResult = new Humidifier.Bedrock.GuardrailVersion
        {
            GivenName = InputResourceName,
        };

        return guardrailVersionResult;
    }

} // End Of Class

public static class GuardrailVersionFactoryExtensions
{
}
