// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetAnywhereConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.AnywhereConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.AnywhereConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.AnywhereConfiguration Create()
    {
        var anywhereConfigurationResult = CreateAnywhereConfiguration();
        factoryAction?.Invoke(anywhereConfigurationResult);

        return anywhereConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.AnywhereConfiguration CreateAnywhereConfiguration()
    {
        var anywhereConfigurationResult = new Humidifier.GameLift.FleetTypes.AnywhereConfiguration();

        return anywhereConfigurationResult;
    }

} // End Of Class

public static class InnerFleetAnywhereConfigurationFactoryExtensions
{
}
