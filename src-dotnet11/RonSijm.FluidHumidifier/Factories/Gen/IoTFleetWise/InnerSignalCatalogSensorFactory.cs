// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerSignalCatalogSensorFactory(Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Sensor> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.SignalCatalogTypes.Sensor>
{

    protected override Humidifier.IoTFleetWise.SignalCatalogTypes.Sensor Create()
    {
        var sensorResult = CreateSensor();
        factoryAction?.Invoke(sensorResult);

        return sensorResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalogTypes.Sensor CreateSensor()
    {
        var sensorResult = new Humidifier.IoTFleetWise.SignalCatalogTypes.Sensor();

        return sensorResult;
    }

} // End Of Class

public static class InnerSignalCatalogSensorFactoryExtensions
{
}
