// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerHarvestJobHarvesterScheduleConfigurationFactory(Action<Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration>
{

    protected override Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration Create()
    {
        var harvesterScheduleConfigurationResult = CreateHarvesterScheduleConfiguration();
        factoryAction?.Invoke(harvesterScheduleConfigurationResult);

        return harvesterScheduleConfigurationResult;
    }

    private Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration CreateHarvesterScheduleConfiguration()
    {
        var harvesterScheduleConfigurationResult = new Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration();

        return harvesterScheduleConfigurationResult;
    }

} // End Of Class

public static class InnerHarvestJobHarvesterScheduleConfigurationFactoryExtensions
{
}
