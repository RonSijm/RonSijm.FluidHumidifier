// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerSignalCatalogActuatorFactory(Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Actuator> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.SignalCatalogTypes.Actuator>
{

    protected override Humidifier.IoTFleetWise.SignalCatalogTypes.Actuator Create()
    {
        var actuatorResult = CreateActuator();
        factoryAction?.Invoke(actuatorResult);

        return actuatorResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalogTypes.Actuator CreateActuator()
    {
        var actuatorResult = new Humidifier.IoTFleetWise.SignalCatalogTypes.Actuator();

        return actuatorResult;
    }

} // End Of Class

public static class InnerSignalCatalogActuatorFactoryExtensions
{
}
