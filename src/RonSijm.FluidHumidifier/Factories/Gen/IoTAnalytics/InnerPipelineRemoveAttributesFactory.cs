// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineRemoveAttributesFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.RemoveAttributes> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.RemoveAttributes>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.RemoveAttributes Create()
    {
        var removeAttributesResult = CreateRemoveAttributes();
        factoryAction?.Invoke(removeAttributesResult);

        return removeAttributesResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.RemoveAttributes CreateRemoveAttributes()
    {
        var removeAttributesResult = new Humidifier.IoTAnalytics.PipelineTypes.RemoveAttributes();

        return removeAttributesResult;
    }

} // End Of Class

public static class InnerPipelineRemoveAttributesFactoryExtensions
{
}
