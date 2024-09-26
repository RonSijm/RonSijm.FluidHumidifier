// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerDetectorLabelFactory(Action<Humidifier.FraudDetector.DetectorTypes.Label> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.DetectorTypes.Label>
{

    protected override Humidifier.FraudDetector.DetectorTypes.Label Create()
    {
        var labelResult = CreateLabel();
        factoryAction?.Invoke(labelResult);

        return labelResult;
    }

    private Humidifier.FraudDetector.DetectorTypes.Label CreateLabel()
    {
        var labelResult = new Humidifier.FraudDetector.DetectorTypes.Label();

        return labelResult;
    }

} // End Of Class

public static class InnerDetectorLabelFactoryExtensions
{
}
