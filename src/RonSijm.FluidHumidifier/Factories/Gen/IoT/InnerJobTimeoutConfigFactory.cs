// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTimeoutConfigFactory(Action<Humidifier.IoT.JobTypes.TimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.TimeoutConfig>
{

    protected override Humidifier.IoT.JobTypes.TimeoutConfig Create()
    {
        var timeoutConfigResult = CreateTimeoutConfig();
        factoryAction?.Invoke(timeoutConfigResult);

        return timeoutConfigResult;
    }

    private Humidifier.IoT.JobTypes.TimeoutConfig CreateTimeoutConfig()
    {
        var timeoutConfigResult = new Humidifier.IoT.JobTypes.TimeoutConfig();

        return timeoutConfigResult;
    }

} // End Of Class

public static class InnerJobTimeoutConfigFactoryExtensions
{
}
