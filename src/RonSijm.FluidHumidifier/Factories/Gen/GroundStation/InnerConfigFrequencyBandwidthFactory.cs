// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigFrequencyBandwidthFactory(Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth>
{

    protected override Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth Create()
    {
        var frequencyBandwidthResult = CreateFrequencyBandwidth();
        factoryAction?.Invoke(frequencyBandwidthResult);

        return frequencyBandwidthResult;
    }

    private Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth CreateFrequencyBandwidth()
    {
        var frequencyBandwidthResult = new Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth();

        return frequencyBandwidthResult;
    }

} // End Of Class

public static class InnerConfigFrequencyBandwidthFactoryExtensions
{
}
