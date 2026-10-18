// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerAnomalyDetectorLabelFactory(Action<Humidifier.APS.AnomalyDetectorTypes.Label> factoryAction = null) : SubResourceFactory<Humidifier.APS.AnomalyDetectorTypes.Label>
{

    protected override Humidifier.APS.AnomalyDetectorTypes.Label Create()
    {
        var labelResult = CreateLabel();
        factoryAction?.Invoke(labelResult);

        return labelResult;
    }

    private Humidifier.APS.AnomalyDetectorTypes.Label CreateLabel()
    {
        var labelResult = new Humidifier.APS.AnomalyDetectorTypes.Label();

        return labelResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorLabelFactoryExtensions
{
}
