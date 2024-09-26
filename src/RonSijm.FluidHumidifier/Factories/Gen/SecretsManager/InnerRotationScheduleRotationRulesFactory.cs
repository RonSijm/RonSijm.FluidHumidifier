// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class InnerRotationScheduleRotationRulesFactory(Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> factoryAction = null) : SubResourceFactory<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules>
{

    protected override Humidifier.SecretsManager.RotationScheduleTypes.RotationRules Create()
    {
        var rotationRulesResult = CreateRotationRules();
        factoryAction?.Invoke(rotationRulesResult);

        return rotationRulesResult;
    }

    private Humidifier.SecretsManager.RotationScheduleTypes.RotationRules CreateRotationRules()
    {
        var rotationRulesResult = new Humidifier.SecretsManager.RotationScheduleTypes.RotationRules();

        return rotationRulesResult;
    }

} // End Of Class

public static class InnerRotationScheduleRotationRulesFactoryExtensions
{
}
