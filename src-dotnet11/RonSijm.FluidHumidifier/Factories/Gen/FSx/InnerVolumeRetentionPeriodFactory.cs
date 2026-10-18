// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeRetentionPeriodFactory(Action<Humidifier.FSx.VolumeTypes.RetentionPeriod> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.RetentionPeriod>
{

    protected override Humidifier.FSx.VolumeTypes.RetentionPeriod Create()
    {
        var retentionPeriodResult = CreateRetentionPeriod();
        factoryAction?.Invoke(retentionPeriodResult);

        return retentionPeriodResult;
    }

    private Humidifier.FSx.VolumeTypes.RetentionPeriod CreateRetentionPeriod()
    {
        var retentionPeriodResult = new Humidifier.FSx.VolumeTypes.RetentionPeriod();

        return retentionPeriodResult;
    }

} // End Of Class

public static class InnerVolumeRetentionPeriodFactoryExtensions
{
}
