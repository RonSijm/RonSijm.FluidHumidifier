// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class OutcomeFactory(string resourceName = null, Action<Humidifier.FraudDetector.Outcome> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.Outcome>(resourceName)
{

    protected override Humidifier.FraudDetector.Outcome Create()
    {
        var outcomeResult = CreateOutcome();
        factoryAction?.Invoke(outcomeResult);

        return outcomeResult;
    }

    private Humidifier.FraudDetector.Outcome CreateOutcome()
    {
        var outcomeResult = new Humidifier.FraudDetector.Outcome
        {
            GivenName = InputResourceName,
        };

        return outcomeResult;
    }

} // End Of Class

public static class OutcomeFactoryExtensions
{
}
