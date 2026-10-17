// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorBasicAuthConnectionMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata Create()
    {
        var basicAuthConnectionMetadataResult = CreateBasicAuthConnectionMetadata();
        factoryAction?.Invoke(basicAuthConnectionMetadataResult);

        return basicAuthConnectionMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata CreateBasicAuthConnectionMetadata()
    {
        var basicAuthConnectionMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata();

        return basicAuthConnectionMetadataResult;
    }

} // End Of Class

public static class InnerActionConnectorBasicAuthConnectionMetadataFactoryExtensions
{
}
