// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerAnomalyDetectorIgnoreNearExpectedFactory(Action<Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected> factoryAction = null) : SubResourceFactory<Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected>
{

    protected override Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected Create()
    {
        var ignoreNearExpectedResult = CreateIgnoreNearExpected();
        factoryAction?.Invoke(ignoreNearExpectedResult);

        return ignoreNearExpectedResult;
    }

    private Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected CreateIgnoreNearExpected()
    {
        var ignoreNearExpectedResult = new Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected();

        return ignoreNearExpectedResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorIgnoreNearExpectedFactoryExtensions
{
}
