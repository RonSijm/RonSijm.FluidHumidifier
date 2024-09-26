// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class VariableFactory(string resourceName = null, Action<Humidifier.FraudDetector.Variable> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.Variable>(resourceName)
{

    protected override Humidifier.FraudDetector.Variable Create()
    {
        var variableResult = CreateVariable();
        factoryAction?.Invoke(variableResult);

        return variableResult;
    }

    private Humidifier.FraudDetector.Variable CreateVariable()
    {
        var variableResult = new Humidifier.FraudDetector.Variable
        {
            GivenName = InputResourceName,
        };

        return variableResult;
    }

} // End Of Class

public static class VariableFactoryExtensions
{
}
