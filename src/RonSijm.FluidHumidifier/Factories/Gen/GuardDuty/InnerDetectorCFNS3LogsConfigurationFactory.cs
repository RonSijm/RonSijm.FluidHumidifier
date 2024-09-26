// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorCFNS3LogsConfigurationFactory(Action<Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration>
{

    protected override Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration Create()
    {
        var cFNS3LogsConfigurationResult = CreateCFNS3LogsConfiguration();
        factoryAction?.Invoke(cFNS3LogsConfigurationResult);

        return cFNS3LogsConfigurationResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration CreateCFNS3LogsConfiguration()
    {
        var cFNS3LogsConfigurationResult = new Humidifier.GuardDuty.DetectorTypes.CFNS3LogsConfiguration();

        return cFNS3LogsConfigurationResult;
    }

} // End Of Class

public static class InnerDetectorCFNS3LogsConfigurationFactoryExtensions
{
}
