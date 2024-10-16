// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryRunConfigFactory(Action<Humidifier.Synthetics.CanaryTypes.RunConfig> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.RunConfig>
{

    protected override Humidifier.Synthetics.CanaryTypes.RunConfig Create()
    {
        var runConfigResult = CreateRunConfig();
        factoryAction?.Invoke(runConfigResult);

        return runConfigResult;
    }

    private Humidifier.Synthetics.CanaryTypes.RunConfig CreateRunConfig()
    {
        var runConfigResult = new Humidifier.Synthetics.CanaryTypes.RunConfig();

        return runConfigResult;
    }

} // End Of Class

public static class InnerCanaryRunConfigFactoryExtensions
{
}
