// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigDecodeConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.DecodeConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.DecodeConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.DecodeConfig Create()
    {
        var decodeConfigResult = CreateDecodeConfig();
        factoryAction?.Invoke(decodeConfigResult);

        return decodeConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.DecodeConfig CreateDecodeConfig()
    {
        var decodeConfigResult = new Humidifier.GroundStation.ConfigTypes.DecodeConfig();

        return decodeConfigResult;
    }

} // End Of Class

public static class InnerConfigDecodeConfigFactoryExtensions
{
}
