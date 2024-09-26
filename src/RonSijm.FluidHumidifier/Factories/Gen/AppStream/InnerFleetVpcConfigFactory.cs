// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerFleetVpcConfigFactory(Action<Humidifier.AppStream.FleetTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.FleetTypes.VpcConfig>
{

    protected override Humidifier.AppStream.FleetTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.AppStream.FleetTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.AppStream.FleetTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerFleetVpcConfigFactoryExtensions
{
}
