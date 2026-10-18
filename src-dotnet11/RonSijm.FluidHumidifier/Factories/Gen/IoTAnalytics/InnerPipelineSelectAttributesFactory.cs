// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineSelectAttributesFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.SelectAttributes> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.SelectAttributes>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.SelectAttributes Create()
    {
        var selectAttributesResult = CreateSelectAttributes();
        factoryAction?.Invoke(selectAttributesResult);

        return selectAttributesResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.SelectAttributes CreateSelectAttributes()
    {
        var selectAttributesResult = new Humidifier.IoTAnalytics.PipelineTypes.SelectAttributes();

        return selectAttributesResult;
    }

} // End Of Class

public static class InnerPipelineSelectAttributesFactoryExtensions
{
}
