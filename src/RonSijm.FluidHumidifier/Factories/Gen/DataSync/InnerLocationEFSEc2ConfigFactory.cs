// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationEFSEc2ConfigFactory(Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationEFSTypes.Ec2Config>
{

    protected override Humidifier.DataSync.LocationEFSTypes.Ec2Config Create()
    {
        var ec2ConfigResult = CreateEc2Config();
        factoryAction?.Invoke(ec2ConfigResult);

        return ec2ConfigResult;
    }

    private Humidifier.DataSync.LocationEFSTypes.Ec2Config CreateEc2Config()
    {
        var ec2ConfigResult = new Humidifier.DataSync.LocationEFSTypes.Ec2Config();

        return ec2ConfigResult;
    }

} // End Of Class

public static class InnerLocationEFSEc2ConfigFactoryExtensions
{
}
