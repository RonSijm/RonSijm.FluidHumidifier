// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerFleetVpcConfigFactory(Action<Humidifier.CodeBuild.FleetTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.FleetTypes.VpcConfig>
{

    protected override Humidifier.CodeBuild.FleetTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.CodeBuild.FleetTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.CodeBuild.FleetTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerFleetVpcConfigFactoryExtensions
{
}
