// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Proton;

public class EnvironmentTemplateFactory(string resourceName = null, Action<Humidifier.Proton.EnvironmentTemplate> factoryAction = null) : ResourceFactory<Humidifier.Proton.EnvironmentTemplate>(resourceName)
{

    protected override Humidifier.Proton.EnvironmentTemplate Create()
    {
        var environmentTemplateResult = CreateEnvironmentTemplate();
        factoryAction?.Invoke(environmentTemplateResult);

        return environmentTemplateResult;
    }

    private Humidifier.Proton.EnvironmentTemplate CreateEnvironmentTemplate()
    {
        var environmentTemplateResult = new Humidifier.Proton.EnvironmentTemplate
        {
            GivenName = InputResourceName,
        };

        return environmentTemplateResult;
    }

} // End Of Class

public static class EnvironmentTemplateFactoryExtensions
{
}
