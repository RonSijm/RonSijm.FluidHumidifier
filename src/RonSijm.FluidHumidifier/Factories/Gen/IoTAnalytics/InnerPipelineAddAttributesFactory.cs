// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineAddAttributesFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.AddAttributes> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.AddAttributes>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.AddAttributes Create()
    {
        var addAttributesResult = CreateAddAttributes();
        factoryAction?.Invoke(addAttributesResult);

        return addAttributesResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.AddAttributes CreateAddAttributes()
    {
        var addAttributesResult = new Humidifier.IoTAnalytics.PipelineTypes.AddAttributes();

        return addAttributesResult;
    }

} // End Of Class

public static class InnerPipelineAddAttributesFactoryExtensions
{
}
