// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerQuantumTaskExperimentalCapabilitiesFactory(Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities>
{

    protected override Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities Create()
    {
        var experimentalCapabilitiesResult = CreateExperimentalCapabilities();
        factoryAction?.Invoke(experimentalCapabilitiesResult);

        return experimentalCapabilitiesResult;
    }

    private Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities CreateExperimentalCapabilities()
    {
        var experimentalCapabilitiesResult = new Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities();

        return experimentalCapabilitiesResult;
    }

} // End Of Class

public static class InnerQuantumTaskExperimentalCapabilitiesFactoryExtensions
{
}
