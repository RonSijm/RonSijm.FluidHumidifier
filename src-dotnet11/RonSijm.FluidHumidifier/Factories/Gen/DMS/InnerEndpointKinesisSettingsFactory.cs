// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointKinesisSettingsFactory(Action<Humidifier.DMS.EndpointTypes.KinesisSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.KinesisSettings>
{

    protected override Humidifier.DMS.EndpointTypes.KinesisSettings Create()
    {
        var kinesisSettingsResult = CreateKinesisSettings();
        factoryAction?.Invoke(kinesisSettingsResult);

        return kinesisSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.KinesisSettings CreateKinesisSettings()
    {
        var kinesisSettingsResult = new Humidifier.DMS.EndpointTypes.KinesisSettings();

        return kinesisSettingsResult;
    }

} // End Of Class

public static class InnerEndpointKinesisSettingsFactoryExtensions
{
}
