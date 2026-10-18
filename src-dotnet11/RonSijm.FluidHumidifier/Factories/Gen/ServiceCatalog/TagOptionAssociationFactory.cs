// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class TagOptionAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.TagOptionAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.TagOptionAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalog.TagOptionAssociation Create()
    {
        var tagOptionAssociationResult = CreateTagOptionAssociation();
        factoryAction?.Invoke(tagOptionAssociationResult);

        return tagOptionAssociationResult;
    }

    private Humidifier.ServiceCatalog.TagOptionAssociation CreateTagOptionAssociation()
    {
        var tagOptionAssociationResult = new Humidifier.ServiceCatalog.TagOptionAssociation
        {
            GivenName = InputResourceName,
        };

        return tagOptionAssociationResult;
    }

} // End Of Class

public static class TagOptionAssociationFactoryExtensions
{
}
