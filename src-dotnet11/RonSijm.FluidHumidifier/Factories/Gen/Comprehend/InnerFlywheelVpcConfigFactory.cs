// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerFlywheelVpcConfigFactory(Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.FlywheelTypes.VpcConfig>
{

    protected override Humidifier.Comprehend.FlywheelTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Comprehend.FlywheelTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Comprehend.FlywheelTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerFlywheelVpcConfigFactoryExtensions
{
}
