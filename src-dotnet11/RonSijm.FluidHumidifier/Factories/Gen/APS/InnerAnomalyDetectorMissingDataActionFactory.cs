// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerAnomalyDetectorMissingDataActionFactory(Action<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction> factoryAction = null) : SubResourceFactory<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction>
{

    protected override Humidifier.APS.AnomalyDetectorTypes.MissingDataAction Create()
    {
        var missingDataActionResult = CreateMissingDataAction();
        factoryAction?.Invoke(missingDataActionResult);

        return missingDataActionResult;
    }

    private Humidifier.APS.AnomalyDetectorTypes.MissingDataAction CreateMissingDataAction()
    {
        var missingDataActionResult = new Humidifier.APS.AnomalyDetectorTypes.MissingDataAction();

        return missingDataActionResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorMissingDataActionFactoryExtensions
{
}
