// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerDetectorModelFactory(Action<Humidifier.FraudDetector.DetectorTypes.Model> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.DetectorTypes.Model>
{

    protected override Humidifier.FraudDetector.DetectorTypes.Model Create()
    {
        var modelResult = CreateModel();
        factoryAction?.Invoke(modelResult);

        return modelResult;
    }

    private Humidifier.FraudDetector.DetectorTypes.Model CreateModel()
    {
        var modelResult = new Humidifier.FraudDetector.DetectorTypes.Model();

        return modelResult;
    }

} // End Of Class

public static class InnerDetectorModelFactoryExtensions
{
}
