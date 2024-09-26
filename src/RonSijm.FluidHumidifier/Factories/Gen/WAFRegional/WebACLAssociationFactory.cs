// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class WebACLAssociationFactory(string resourceName = null, Action<Humidifier.WAFRegional.WebACLAssociation> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.WebACLAssociation>(resourceName)
{

    protected override Humidifier.WAFRegional.WebACLAssociation Create()
    {
        var webACLAssociationResult = CreateWebACLAssociation();
        factoryAction?.Invoke(webACLAssociationResult);

        return webACLAssociationResult;
    }

    private Humidifier.WAFRegional.WebACLAssociation CreateWebACLAssociation()
    {
        var webACLAssociationResult = new Humidifier.WAFRegional.WebACLAssociation
        {
            GivenName = InputResourceName,
        };

        return webACLAssociationResult;
    }

} // End Of Class

public static class WebACLAssociationFactoryExtensions
{
}
