// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ExtensionAssociationFactory(string resourceName = null, Action<Humidifier.AppConfig.ExtensionAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.ExtensionAssociation>(resourceName)
{

    protected override Humidifier.AppConfig.ExtensionAssociation Create()
    {
        var extensionAssociationResult = CreateExtensionAssociation();
        factoryAction?.Invoke(extensionAssociationResult);

        return extensionAssociationResult;
    }

    private Humidifier.AppConfig.ExtensionAssociation CreateExtensionAssociation()
    {
        var extensionAssociationResult = new Humidifier.AppConfig.ExtensionAssociation
        {
            GivenName = InputResourceName,
        };

        return extensionAssociationResult;
    }

} // End Of Class

public static class ExtensionAssociationFactoryExtensions
{
}
