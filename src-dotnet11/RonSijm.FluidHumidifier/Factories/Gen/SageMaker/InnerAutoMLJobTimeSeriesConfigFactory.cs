// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobTimeSeriesConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig Create()
    {
        var timeSeriesConfigResult = CreateTimeSeriesConfig();
        factoryAction?.Invoke(timeSeriesConfigResult);

        return timeSeriesConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig CreateTimeSeriesConfig()
    {
        var timeSeriesConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig();

        return timeSeriesConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobTimeSeriesConfigFactoryExtensions
{
}
