// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetRuntimeConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.RuntimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.RuntimeConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.RuntimeConfiguration Create()
    {
        var runtimeConfigurationResult = CreateRuntimeConfiguration();
        factoryAction?.Invoke(runtimeConfigurationResult);

        return runtimeConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.RuntimeConfiguration CreateRuntimeConfiguration()
    {
        var runtimeConfigurationResult = new Humidifier.GameLift.FleetTypes.RuntimeConfiguration();

        return runtimeConfigurationResult;
    }

} // End Of Class

public static class InnerFleetRuntimeConfigurationFactoryExtensions
{
}
