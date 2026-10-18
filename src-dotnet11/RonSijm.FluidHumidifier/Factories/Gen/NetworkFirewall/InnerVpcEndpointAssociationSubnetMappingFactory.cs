// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerVpcEndpointAssociationSubnetMappingFactory(Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping>
{

    protected override Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping Create()
    {
        var subnetMappingResult = CreateSubnetMapping();
        factoryAction?.Invoke(subnetMappingResult);

        return subnetMappingResult;
    }

    private Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping CreateSubnetMapping()
    {
        var subnetMappingResult = new Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping();

        return subnetMappingResult;
    }

} // End Of Class

public static class InnerVpcEndpointAssociationSubnetMappingFactoryExtensions
{
}
