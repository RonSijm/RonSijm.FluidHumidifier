// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class LabelFactory(string resourceName = null, Action<Humidifier.FraudDetector.Label> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.Label>(resourceName)
{

    protected override Humidifier.FraudDetector.Label Create()
    {
        var labelResult = CreateLabel();
        factoryAction?.Invoke(labelResult);

        return labelResult;
    }

    private Humidifier.FraudDetector.Label CreateLabel()
    {
        var labelResult = new Humidifier.FraudDetector.Label
        {
            GivenName = InputResourceName,
        };

        return labelResult;
    }

} // End Of Class

public static class LabelFactoryExtensions
{
}
