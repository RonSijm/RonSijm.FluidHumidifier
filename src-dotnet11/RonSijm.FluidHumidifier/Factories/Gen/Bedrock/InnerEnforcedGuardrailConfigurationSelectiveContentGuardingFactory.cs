// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerEnforcedGuardrailConfigurationSelectiveContentGuardingFactory(Action<Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding>
{

    protected override Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding Create()
    {
        var selectiveContentGuardingResult = CreateSelectiveContentGuarding();
        factoryAction?.Invoke(selectiveContentGuardingResult);

        return selectiveContentGuardingResult;
    }

    private Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding CreateSelectiveContentGuarding()
    {
        var selectiveContentGuardingResult = new Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding();

        return selectiveContentGuardingResult;
    }

} // End Of Class

public static class InnerEnforcedGuardrailConfigurationSelectiveContentGuardingFactoryExtensions
{
}
