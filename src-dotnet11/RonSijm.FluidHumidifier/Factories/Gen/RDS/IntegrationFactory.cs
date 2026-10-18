// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.RDS.Integration> factoryAction = null) : ResourceFactory<Humidifier.RDS.Integration>(resourceName)
{

    protected override Humidifier.RDS.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.RDS.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.RDS.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
}
