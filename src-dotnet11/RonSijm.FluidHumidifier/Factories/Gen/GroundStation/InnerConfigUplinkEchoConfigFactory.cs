// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigUplinkEchoConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig Create()
    {
        var uplinkEchoConfigResult = CreateUplinkEchoConfig();
        factoryAction?.Invoke(uplinkEchoConfigResult);

        return uplinkEchoConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig CreateUplinkEchoConfig()
    {
        var uplinkEchoConfigResult = new Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig();

        return uplinkEchoConfigResult;
    }

} // End Of Class

public static class InnerConfigUplinkEchoConfigFactoryExtensions
{
}
