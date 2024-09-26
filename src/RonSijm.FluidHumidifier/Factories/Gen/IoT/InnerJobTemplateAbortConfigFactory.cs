// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateAbortConfigFactory(Action<Humidifier.IoT.JobTemplateTypes.AbortConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.AbortConfig>
{

    protected override Humidifier.IoT.JobTemplateTypes.AbortConfig Create()
    {
        var abortConfigResult = CreateAbortConfig();
        factoryAction?.Invoke(abortConfigResult);

        return abortConfigResult;
    }

    private Humidifier.IoT.JobTemplateTypes.AbortConfig CreateAbortConfig()
    {
        var abortConfigResult = new Humidifier.IoT.JobTemplateTypes.AbortConfig();

        return abortConfigResult;
    }

} // End Of Class

public static class InnerJobTemplateAbortConfigFactoryExtensions
{
}
