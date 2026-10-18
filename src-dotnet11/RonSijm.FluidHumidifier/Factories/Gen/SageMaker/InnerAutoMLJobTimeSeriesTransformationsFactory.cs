// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobTimeSeriesTransformationsFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations Create()
    {
        var timeSeriesTransformationsResult = CreateTimeSeriesTransformations();
        factoryAction?.Invoke(timeSeriesTransformationsResult);

        return timeSeriesTransformationsResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations CreateTimeSeriesTransformations()
    {
        var timeSeriesTransformationsResult = new Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations();

        return timeSeriesTransformationsResult;
    }

} // End Of Class

public static class InnerAutoMLJobTimeSeriesTransformationsFactoryExtensions
{
}
