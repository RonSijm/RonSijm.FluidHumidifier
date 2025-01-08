// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceVpcLatticeConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration Create()
    {
        var vpcLatticeConfigurationResult = CreateVpcLatticeConfiguration();
        factoryAction?.Invoke(vpcLatticeConfigurationResult);

        return vpcLatticeConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration CreateVpcLatticeConfiguration()
    {
        var vpcLatticeConfigurationResult = new Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration();

        return vpcLatticeConfigurationResult;
    }

} // End Of Class

public static class InnerServiceVpcLatticeConfigurationFactoryExtensions
{
}
