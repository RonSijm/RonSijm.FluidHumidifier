// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerEnforcedGuardrailConfigurationModelEnforcementFactory(Action<Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement>
{

    protected override Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement Create()
    {
        var modelEnforcementResult = CreateModelEnforcement();
        factoryAction?.Invoke(modelEnforcementResult);

        return modelEnforcementResult;
    }

    private Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement CreateModelEnforcement()
    {
        var modelEnforcementResult = new Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement();

        return modelEnforcementResult;
    }

} // End Of Class

public static class InnerEnforcedGuardrailConfigurationModelEnforcementFactoryExtensions
{
}
