// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobAbortConfigFactory(Action<Humidifier.IoT.JobTypes.AbortConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.AbortConfig>
{

    protected override Humidifier.IoT.JobTypes.AbortConfig Create()
    {
        var abortConfigResult = CreateAbortConfig();
        factoryAction?.Invoke(abortConfigResult);

        return abortConfigResult;
    }

    private Humidifier.IoT.JobTypes.AbortConfig CreateAbortConfig()
    {
        var abortConfigResult = new Humidifier.IoT.JobTypes.AbortConfig();

        return abortConfigResult;
    }

} // End Of Class

public static class InnerJobAbortConfigFactoryExtensions
{
}
