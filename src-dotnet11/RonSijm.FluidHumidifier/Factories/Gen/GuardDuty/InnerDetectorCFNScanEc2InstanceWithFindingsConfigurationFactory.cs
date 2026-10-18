// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorCFNScanEc2InstanceWithFindingsConfigurationFactory(Action<Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration>
{

    protected override Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration Create()
    {
        var cFNScanEc2InstanceWithFindingsConfigurationResult = CreateCFNScanEc2InstanceWithFindingsConfiguration();
        factoryAction?.Invoke(cFNScanEc2InstanceWithFindingsConfigurationResult);

        return cFNScanEc2InstanceWithFindingsConfigurationResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration CreateCFNScanEc2InstanceWithFindingsConfiguration()
    {
        var cFNScanEc2InstanceWithFindingsConfigurationResult = new Humidifier.GuardDuty.DetectorTypes.CFNScanEc2InstanceWithFindingsConfiguration();

        return cFNScanEc2InstanceWithFindingsConfigurationResult;
    }

} // End Of Class

public static class InnerDetectorCFNScanEc2InstanceWithFindingsConfigurationFactoryExtensions
{
}
