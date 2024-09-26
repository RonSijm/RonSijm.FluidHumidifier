// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class ServicePrincipalNameFactory(string resourceName = null, Action<Humidifier.PCAConnectorAD.ServicePrincipalName> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorAD.ServicePrincipalName>(resourceName)
{

    protected override Humidifier.PCAConnectorAD.ServicePrincipalName Create()
    {
        var servicePrincipalNameResult = CreateServicePrincipalName();
        factoryAction?.Invoke(servicePrincipalNameResult);

        return servicePrincipalNameResult;
    }

    private Humidifier.PCAConnectorAD.ServicePrincipalName CreateServicePrincipalName()
    {
        var servicePrincipalNameResult = new Humidifier.PCAConnectorAD.ServicePrincipalName
        {
            GivenName = InputResourceName,
        };

        return servicePrincipalNameResult;
    }

} // End Of Class

public static class ServicePrincipalNameFactoryExtensions
{
}
