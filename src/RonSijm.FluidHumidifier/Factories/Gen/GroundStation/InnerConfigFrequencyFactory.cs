// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigFrequencyFactory(Action<Humidifier.GroundStation.ConfigTypes.Frequency> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.Frequency>
{

    protected override Humidifier.GroundStation.ConfigTypes.Frequency Create()
    {
        var frequencyResult = CreateFrequency();
        factoryAction?.Invoke(frequencyResult);

        return frequencyResult;
    }

    private Humidifier.GroundStation.ConfigTypes.Frequency CreateFrequency()
    {
        var frequencyResult = new Humidifier.GroundStation.ConfigTypes.Frequency();

        return frequencyResult;
    }

} // End Of Class

public static class InnerConfigFrequencyFactoryExtensions
{
}
