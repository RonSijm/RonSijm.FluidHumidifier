// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class InnerMetadataTransferJobSourceConfigurationFactory(Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration>
{

    protected override Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }

} // End Of Class

public static class InnerMetadataTransferJobSourceConfigurationFactoryExtensions
{
}
