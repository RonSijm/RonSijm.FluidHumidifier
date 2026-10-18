// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointServiceFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpointService> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpointService>(resourceName)
{

    internal InnerVPCEndpointServicePrivateDnsNameConfigurationFactory PrivateDnsNameConfigurationFactory { get; set; }

    protected override Humidifier.EC2.VPCEndpointService Create()
    {
        var vPCEndpointServiceResult = CreateVPCEndpointService();
        factoryAction?.Invoke(vPCEndpointServiceResult);

        return vPCEndpointServiceResult;
    }

    private Humidifier.EC2.VPCEndpointService CreateVPCEndpointService()
    {
        var vPCEndpointServiceResult = new Humidifier.EC2.VPCEndpointService
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointServiceResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPCEndpointService result)
    {
        base.CreateChildren(result);

        result.PrivateDnsNameConfiguration ??= PrivateDnsNameConfigurationFactory?.Build();
    }

} // End Of Class

public static class VPCEndpointServiceFactoryExtensions
{
    public static CombinedResult<VPCEndpointServiceFactory, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration(this VPCEndpointServiceFactory parentFactory, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null)
    {
        parentFactory.PrivateDnsNameConfigurationFactory = new InnerVPCEndpointServicePrivateDnsNameConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateDnsNameConfigurationFactory);
    }

    public static CombinedResult<VPCEndpointServiceFactory, T1, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1>(this CombinedResult<VPCEndpointServiceFactory, T1> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCEndpointServiceFactory, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1>(this CombinedResult<T1, VPCEndpointServiceFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VPCEndpointServiceFactory, T1, T2, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2>(this CombinedResult<VPCEndpointServiceFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCEndpointServiceFactory, T2, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2>(this CombinedResult<T1, VPCEndpointServiceFactory, T2> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCEndpointServiceFactory, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2>(this CombinedResult<T1, T2, VPCEndpointServiceFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VPCEndpointServiceFactory, T1, T2, T3, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3>(this CombinedResult<VPCEndpointServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCEndpointServiceFactory, T2, T3, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3>(this CombinedResult<T1, VPCEndpointServiceFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCEndpointServiceFactory, T3, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, VPCEndpointServiceFactory, T3> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VPCEndpointServiceFactory, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, VPCEndpointServiceFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VPCEndpointServiceFactory, T1, T2, T3, T4, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3, T4>(this CombinedResult<VPCEndpointServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCEndpointServiceFactory, T2, T3, T4, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, VPCEndpointServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCEndpointServiceFactory, T3, T4, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, VPCEndpointServiceFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VPCEndpointServiceFactory, T4, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VPCEndpointServiceFactory, T4> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VPCEndpointServiceFactory, InnerVPCEndpointServicePrivateDnsNameConfigurationFactory> WithPrivateDnsNameConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VPCEndpointServiceFactory> combinedResult, Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateDnsNameConfiguration(combinedResult.T5, subFactoryAction).T2);
}
