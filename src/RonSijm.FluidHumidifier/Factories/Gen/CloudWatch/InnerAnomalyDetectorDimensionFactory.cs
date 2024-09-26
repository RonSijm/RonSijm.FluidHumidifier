// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorDimensionFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension Create()
    {
        var dimensionResult = CreateDimension();
        factoryAction?.Invoke(dimensionResult);

        return dimensionResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension CreateDimension()
    {
        var dimensionResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension();

        return dimensionResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorDimensionFactoryExtensions
{
}
