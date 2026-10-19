// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class ConfiguredAudienceModelAssociationFactory(string resourceName = null, Action<Humidifier.CleanRooms.ConfiguredAudienceModelAssociation> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.ConfiguredAudienceModelAssociation>(resourceName)
{

    protected override Humidifier.CleanRooms.ConfiguredAudienceModelAssociation Create()
    {
        var configuredAudienceModelAssociationResult = CreateConfiguredAudienceModelAssociation();
        factoryAction?.Invoke(configuredAudienceModelAssociationResult);

        return configuredAudienceModelAssociationResult;
    }

    private Humidifier.CleanRooms.ConfiguredAudienceModelAssociation CreateConfiguredAudienceModelAssociation()
    {
        var configuredAudienceModelAssociationResult = new Humidifier.CleanRooms.ConfiguredAudienceModelAssociation
        {
            GivenName = InputResourceName,
        };

        return configuredAudienceModelAssociationResult;
    }

} // End Of Class

public static class ConfiguredAudienceModelAssociationFactoryExtensions
{
}
