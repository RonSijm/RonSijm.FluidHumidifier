// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceVpcLatticeAdvancedConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration Create()
    {
        var vpcLatticeAdvancedConfigurationResult = CreateVpcLatticeAdvancedConfiguration();
        factoryAction?.Invoke(vpcLatticeAdvancedConfigurationResult);

        return vpcLatticeAdvancedConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration CreateVpcLatticeAdvancedConfiguration()
    {
        var vpcLatticeAdvancedConfigurationResult = new Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration();

        return vpcLatticeAdvancedConfigurationResult;
    }

} // End Of Class

public static class InnerServiceVpcLatticeAdvancedConfigurationFactoryExtensions
{
}
