// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.Redshift.Integration> factoryAction = null) : ResourceFactory<Humidifier.Redshift.Integration>(resourceName)
{

    protected override Humidifier.Redshift.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.Redshift.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.Redshift.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
}
