// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetGuardianOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.GuardianOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.GuardianOptions Create()
    {
        var guardianOptionsResult = CreateGuardianOptions();
        factoryAction?.Invoke(guardianOptionsResult);

        return guardianOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.GuardianOptions CreateGuardianOptions()
    {
        var guardianOptionsResult = new Humidifier.SES.ConfigurationSetTypes.GuardianOptions();

        return guardianOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetGuardianOptionsFactoryExtensions
{
}
