// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateTimeoutConfigFactory(Action<Humidifier.IoT.JobTemplateTypes.TimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.TimeoutConfig>
{

    protected override Humidifier.IoT.JobTemplateTypes.TimeoutConfig Create()
    {
        var timeoutConfigResult = CreateTimeoutConfig();
        factoryAction?.Invoke(timeoutConfigResult);

        return timeoutConfigResult;
    }

    private Humidifier.IoT.JobTemplateTypes.TimeoutConfig CreateTimeoutConfig()
    {
        var timeoutConfigResult = new Humidifier.IoT.JobTemplateTypes.TimeoutConfig();

        return timeoutConfigResult;
    }

} // End Of Class

public static class InnerJobTemplateTimeoutConfigFactoryExtensions
{
}
