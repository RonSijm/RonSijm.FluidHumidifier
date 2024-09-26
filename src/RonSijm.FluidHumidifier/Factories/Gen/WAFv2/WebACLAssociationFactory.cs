// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class WebACLAssociationFactory(string resourceName = null, Action<Humidifier.WAFv2.WebACLAssociation> factoryAction = null) : ResourceFactory<Humidifier.WAFv2.WebACLAssociation>(resourceName)
{

    protected override Humidifier.WAFv2.WebACLAssociation Create()
    {
        var webACLAssociationResult = CreateWebACLAssociation();
        factoryAction?.Invoke(webACLAssociationResult);

        return webACLAssociationResult;
    }

    private Humidifier.WAFv2.WebACLAssociation CreateWebACLAssociation()
    {
        var webACLAssociationResult = new Humidifier.WAFv2.WebACLAssociation
        {
            GivenName = InputResourceName,
        };

        return webACLAssociationResult;
    }

} // End Of Class

public static class WebACLAssociationFactoryExtensions
{
}
