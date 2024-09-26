// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class ServiceActionAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.ServiceActionAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.ServiceActionAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalog.ServiceActionAssociation Create()
    {
        var serviceActionAssociationResult = CreateServiceActionAssociation();
        factoryAction?.Invoke(serviceActionAssociationResult);

        return serviceActionAssociationResult;
    }

    private Humidifier.ServiceCatalog.ServiceActionAssociation CreateServiceActionAssociation()
    {
        var serviceActionAssociationResult = new Humidifier.ServiceCatalog.ServiceActionAssociation
        {
            GivenName = InputResourceName,
        };

        return serviceActionAssociationResult;
    }

} // End Of Class

public static class ServiceActionAssociationFactoryExtensions
{
}
