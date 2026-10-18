// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class TimeSeriesFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.TimeSeries> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.TimeSeries>(resourceName)
{

    protected override Humidifier.IoTSiteWise.TimeSeries Create()
    {
        var timeSeriesResult = CreateTimeSeries();
        factoryAction?.Invoke(timeSeriesResult);

        return timeSeriesResult;
    }

    private Humidifier.IoTSiteWise.TimeSeries CreateTimeSeries()
    {
        var timeSeriesResult = new Humidifier.IoTSiteWise.TimeSeries
        {
            GivenName = InputResourceName,
        };

        return timeSeriesResult;
    }

} // End Of Class

public static class TimeSeriesFactoryExtensions
{
}
