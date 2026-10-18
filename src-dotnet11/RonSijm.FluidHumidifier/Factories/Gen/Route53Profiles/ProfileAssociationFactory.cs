// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Profiles;

public class ProfileAssociationFactory(string resourceName = null, Action<Humidifier.Route53Profiles.ProfileAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53Profiles.ProfileAssociation>(resourceName)
{

    protected override Humidifier.Route53Profiles.ProfileAssociation Create()
    {
        var profileAssociationResult = CreateProfileAssociation();
        factoryAction?.Invoke(profileAssociationResult);

        return profileAssociationResult;
    }

    private Humidifier.Route53Profiles.ProfileAssociation CreateProfileAssociation()
    {
        var profileAssociationResult = new Humidifier.Route53Profiles.ProfileAssociation
        {
            GivenName = InputResourceName,
        };

        return profileAssociationResult;
    }

} // End Of Class

public static class ProfileAssociationFactoryExtensions
{
}
