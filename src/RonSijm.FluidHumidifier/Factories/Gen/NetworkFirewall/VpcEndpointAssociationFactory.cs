// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class VpcEndpointAssociationFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.VpcEndpointAssociation> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.VpcEndpointAssociation>(resourceName)
{

    internal InnerVpcEndpointAssociationSubnetMappingFactory SubnetMappingFactory { get; set; }

    protected override Humidifier.NetworkFirewall.VpcEndpointAssociation Create()
    {
        var vpcEndpointAssociationResult = CreateVpcEndpointAssociation();
        factoryAction?.Invoke(vpcEndpointAssociationResult);

        return vpcEndpointAssociationResult;
    }

    private Humidifier.NetworkFirewall.VpcEndpointAssociation CreateVpcEndpointAssociation()
    {
        var vpcEndpointAssociationResult = new Humidifier.NetworkFirewall.VpcEndpointAssociation
        {
            GivenName = InputResourceName,
        };

        return vpcEndpointAssociationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.VpcEndpointAssociation result)
    {
        base.CreateChildren(result);

        result.SubnetMapping ??= SubnetMappingFactory?.Build();
    }

} // End Of Class

public static class VpcEndpointAssociationFactoryExtensions
{
    public static CombinedResult<VpcEndpointAssociationFactory, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping(this VpcEndpointAssociationFactory parentFactory, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null)
    {
        parentFactory.SubnetMappingFactory = new InnerVpcEndpointAssociationSubnetMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SubnetMappingFactory);
    }

    public static CombinedResult<VpcEndpointAssociationFactory, T1, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1>(this CombinedResult<VpcEndpointAssociationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcEndpointAssociationFactory, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1>(this CombinedResult<T1, VpcEndpointAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VpcEndpointAssociationFactory, T1, T2, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2>(this CombinedResult<VpcEndpointAssociationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcEndpointAssociationFactory, T2, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2>(this CombinedResult<T1, VpcEndpointAssociationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcEndpointAssociationFactory, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2>(this CombinedResult<T1, T2, VpcEndpointAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VpcEndpointAssociationFactory, T1, T2, T3, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3>(this CombinedResult<VpcEndpointAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcEndpointAssociationFactory, T2, T3, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3>(this CombinedResult<T1, VpcEndpointAssociationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcEndpointAssociationFactory, T3, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3>(this CombinedResult<T1, T2, VpcEndpointAssociationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcEndpointAssociationFactory, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, VpcEndpointAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VpcEndpointAssociationFactory, T1, T2, T3, T4, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3, T4>(this CombinedResult<VpcEndpointAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcEndpointAssociationFactory, T2, T3, T4, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3, T4>(this CombinedResult<T1, VpcEndpointAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcEndpointAssociationFactory, T3, T4, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, VpcEndpointAssociationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcEndpointAssociationFactory, T4, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VpcEndpointAssociationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VpcEndpointAssociationFactory, InnerVpcEndpointAssociationSubnetMappingFactory> WithSubnetMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VpcEndpointAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.VpcEndpointAssociationTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMapping(combinedResult.T5, subFactoryAction).T2);
}
