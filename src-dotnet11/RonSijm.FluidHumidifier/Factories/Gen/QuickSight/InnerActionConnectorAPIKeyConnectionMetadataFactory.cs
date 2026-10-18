// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorAPIKeyConnectionMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata Create()
    {
        var aPIKeyConnectionMetadataResult = CreateAPIKeyConnectionMetadata();
        factoryAction?.Invoke(aPIKeyConnectionMetadataResult);

        return aPIKeyConnectionMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata CreateAPIKeyConnectionMetadata()
    {
        var aPIKeyConnectionMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata();

        return aPIKeyConnectionMetadataResult;
    }

} // End Of Class

public static class InnerActionConnectorAPIKeyConnectionMetadataFactoryExtensions
{
}
