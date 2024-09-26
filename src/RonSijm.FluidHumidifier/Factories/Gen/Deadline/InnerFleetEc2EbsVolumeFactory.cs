// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetEc2EbsVolumeFactory(Action<Humidifier.Deadline.FleetTypes.Ec2EbsVolume> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.Ec2EbsVolume>
{

    protected override Humidifier.Deadline.FleetTypes.Ec2EbsVolume Create()
    {
        var ec2EbsVolumeResult = CreateEc2EbsVolume();
        factoryAction?.Invoke(ec2EbsVolumeResult);

        return ec2EbsVolumeResult;
    }

    private Humidifier.Deadline.FleetTypes.Ec2EbsVolume CreateEc2EbsVolume()
    {
        var ec2EbsVolumeResult = new Humidifier.Deadline.FleetTypes.Ec2EbsVolume();

        return ec2EbsVolumeResult;
    }

} // End Of Class

public static class InnerFleetEc2EbsVolumeFactoryExtensions
{
}
