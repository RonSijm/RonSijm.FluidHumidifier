// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryVPCConfigFactory(Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.VPCConfig>
{

    protected override Humidifier.Synthetics.CanaryTypes.VPCConfig Create()
    {
        var vPCConfigResult = CreateVPCConfig();
        factoryAction?.Invoke(vPCConfigResult);

        return vPCConfigResult;
    }

    private Humidifier.Synthetics.CanaryTypes.VPCConfig CreateVPCConfig()
    {
        var vPCConfigResult = new Humidifier.Synthetics.CanaryTypes.VPCConfig();

        return vPCConfigResult;
    }

} // End Of Class

public static class InnerCanaryVPCConfigFactoryExtensions
{
}
