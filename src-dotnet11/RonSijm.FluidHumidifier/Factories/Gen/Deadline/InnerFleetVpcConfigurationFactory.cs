// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetVpcConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.VpcConfiguration>
{

    protected override Humidifier.Deadline.FleetTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.Deadline.FleetTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerFleetVpcConfigurationFactoryExtensions
{
}
