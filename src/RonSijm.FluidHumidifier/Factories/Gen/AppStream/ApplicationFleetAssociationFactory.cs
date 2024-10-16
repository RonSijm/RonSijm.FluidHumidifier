// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class ApplicationFleetAssociationFactory(string resourceName = null, Action<Humidifier.AppStream.ApplicationFleetAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppStream.ApplicationFleetAssociation>(resourceName)
{

    protected override Humidifier.AppStream.ApplicationFleetAssociation Create()
    {
        var applicationFleetAssociationResult = CreateApplicationFleetAssociation();
        factoryAction?.Invoke(applicationFleetAssociationResult);

        return applicationFleetAssociationResult;
    }

    private Humidifier.AppStream.ApplicationFleetAssociation CreateApplicationFleetAssociation()
    {
        var applicationFleetAssociationResult = new Humidifier.AppStream.ApplicationFleetAssociation
        {
            GivenName = InputResourceName,
        };

        return applicationFleetAssociationResult;
    }

} // End Of Class

public static class ApplicationFleetAssociationFactoryExtensions
{
}
