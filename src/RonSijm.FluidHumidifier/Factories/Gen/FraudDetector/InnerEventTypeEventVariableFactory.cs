// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerEventTypeEventVariableFactory(Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.EventTypeTypes.EventVariable>
{

    protected override Humidifier.FraudDetector.EventTypeTypes.EventVariable Create()
    {
        var eventVariableResult = CreateEventVariable();
        factoryAction?.Invoke(eventVariableResult);

        return eventVariableResult;
    }

    private Humidifier.FraudDetector.EventTypeTypes.EventVariable CreateEventVariable()
    {
        var eventVariableResult = new Humidifier.FraudDetector.EventTypeTypes.EventVariable();

        return eventVariableResult;
    }

} // End Of Class

public static class InnerEventTypeEventVariableFactoryExtensions
{
}
