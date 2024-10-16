// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Profiles;

public class ProfileResourceAssociationFactory(string resourceName = null, Action<Humidifier.Route53Profiles.ProfileResourceAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53Profiles.ProfileResourceAssociation>(resourceName)
{

    protected override Humidifier.Route53Profiles.ProfileResourceAssociation Create()
    {
        var profileResourceAssociationResult = CreateProfileResourceAssociation();
        factoryAction?.Invoke(profileResourceAssociationResult);

        return profileResourceAssociationResult;
    }

    private Humidifier.Route53Profiles.ProfileResourceAssociation CreateProfileResourceAssociation()
    {
        var profileResourceAssociationResult = new Humidifier.Route53Profiles.ProfileResourceAssociation
        {
            GivenName = InputResourceName,
        };

        return profileResourceAssociationResult;
    }

} // End Of Class

public static class ProfileResourceAssociationFactoryExtensions
{
}
