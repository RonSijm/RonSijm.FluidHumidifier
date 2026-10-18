// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DomainNameAccessAssociationFactory(string resourceName = null, Action<Humidifier.ApiGateway.DomainNameAccessAssociation> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.DomainNameAccessAssociation>(resourceName)
{

    protected override Humidifier.ApiGateway.DomainNameAccessAssociation Create()
    {
        var domainNameAccessAssociationResult = CreateDomainNameAccessAssociation();
        factoryAction?.Invoke(domainNameAccessAssociationResult);

        return domainNameAccessAssociationResult;
    }

    private Humidifier.ApiGateway.DomainNameAccessAssociation CreateDomainNameAccessAssociation()
    {
        var domainNameAccessAssociationResult = new Humidifier.ApiGateway.DomainNameAccessAssociation
        {
            GivenName = InputResourceName,
        };

        return domainNameAccessAssociationResult;
    }

} // End Of Class

public static class DomainNameAccessAssociationFactoryExtensions
{
}
