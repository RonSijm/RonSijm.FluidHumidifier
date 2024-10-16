// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class IntegrationAssociationFactory(string resourceName = null, Action<Humidifier.Connect.IntegrationAssociation> factoryAction = null) : ResourceFactory<Humidifier.Connect.IntegrationAssociation>(resourceName)
{

    protected override Humidifier.Connect.IntegrationAssociation Create()
    {
        var integrationAssociationResult = CreateIntegrationAssociation();
        factoryAction?.Invoke(integrationAssociationResult);

        return integrationAssociationResult;
    }

    private Humidifier.Connect.IntegrationAssociation CreateIntegrationAssociation()
    {
        var integrationAssociationResult = new Humidifier.Connect.IntegrationAssociation
        {
            GivenName = InputResourceName,
        };

        return integrationAssociationResult;
    }

} // End Of Class

public static class IntegrationAssociationFactoryExtensions
{
}
