// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerDetectorEventVariableFactory(Action<Humidifier.FraudDetector.DetectorTypes.EventVariable> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.DetectorTypes.EventVariable>
{

    protected override Humidifier.FraudDetector.DetectorTypes.EventVariable Create()
    {
        var eventVariableResult = CreateEventVariable();
        factoryAction?.Invoke(eventVariableResult);

        return eventVariableResult;
    }

    private Humidifier.FraudDetector.DetectorTypes.EventVariable CreateEventVariable()
    {
        var eventVariableResult = new Humidifier.FraudDetector.DetectorTypes.EventVariable();

        return eventVariableResult;
    }

} // End Of Class

public static class InnerDetectorEventVariableFactoryExtensions
{
}
