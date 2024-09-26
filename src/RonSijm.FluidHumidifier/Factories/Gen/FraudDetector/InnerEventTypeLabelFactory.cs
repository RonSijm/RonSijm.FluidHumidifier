// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerEventTypeLabelFactory(Action<Humidifier.FraudDetector.EventTypeTypes.Label> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.EventTypeTypes.Label>
{

    protected override Humidifier.FraudDetector.EventTypeTypes.Label Create()
    {
        var labelResult = CreateLabel();
        factoryAction?.Invoke(labelResult);

        return labelResult;
    }

    private Humidifier.FraudDetector.EventTypeTypes.Label CreateLabel()
    {
        var labelResult = new Humidifier.FraudDetector.EventTypeTypes.Label();

        return labelResult;
    }

} // End Of Class

public static class InnerEventTypeLabelFactoryExtensions
{
}
