// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class DomainNameApiAssociationFactory(string resourceName = null, Action<Humidifier.AppSync.DomainNameApiAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppSync.DomainNameApiAssociation>(resourceName)
{

    protected override Humidifier.AppSync.DomainNameApiAssociation Create()
    {
        var domainNameApiAssociationResult = CreateDomainNameApiAssociation();
        factoryAction?.Invoke(domainNameApiAssociationResult);

        return domainNameApiAssociationResult;
    }

    private Humidifier.AppSync.DomainNameApiAssociation CreateDomainNameApiAssociation()
    {
        var domainNameApiAssociationResult = new Humidifier.AppSync.DomainNameApiAssociation
        {
            GivenName = InputResourceName,
        };

        return domainNameApiAssociationResult;
    }

} // End Of Class

public static class DomainNameApiAssociationFactoryExtensions
{
}
