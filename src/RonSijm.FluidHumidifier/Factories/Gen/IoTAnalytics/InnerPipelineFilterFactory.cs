// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineFilterFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.Filter> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.Filter>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.Filter CreateFilter()
    {
        var filterResult = new Humidifier.IoTAnalytics.PipelineTypes.Filter();

        return filterResult;
    }

} // End Of Class

public static class InnerPipelineFilterFactoryExtensions
{
}
