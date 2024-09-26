// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeAutocommitPeriodFactory(Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.AutocommitPeriod>
{

    protected override Humidifier.FSx.VolumeTypes.AutocommitPeriod Create()
    {
        var autocommitPeriodResult = CreateAutocommitPeriod();
        factoryAction?.Invoke(autocommitPeriodResult);

        return autocommitPeriodResult;
    }

    private Humidifier.FSx.VolumeTypes.AutocommitPeriod CreateAutocommitPeriod()
    {
        var autocommitPeriodResult = new Humidifier.FSx.VolumeTypes.AutocommitPeriod();

        return autocommitPeriodResult;
    }

} // End Of Class

public static class InnerVolumeAutocommitPeriodFactoryExtensions
{
}
