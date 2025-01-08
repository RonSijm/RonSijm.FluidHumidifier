// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetwork> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetwork>(resourceName)
{

    internal InnerServiceNetworkSharingConfigFactory SharingConfigFactory { get; set; }

    protected override Humidifier.VpcLattice.ServiceNetwork Create()
    {
        var serviceNetworkResult = CreateServiceNetwork();
        factoryAction?.Invoke(serviceNetworkResult);

        return serviceNetworkResult;
    }

    private Humidifier.VpcLattice.ServiceNetwork CreateServiceNetwork()
    {
        var serviceNetworkResult = new Humidifier.VpcLattice.ServiceNetwork
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ServiceNetwork result)
    {
        base.CreateChildren(result);

        result.SharingConfig ??= SharingConfigFactory?.Build();
    }

} // End Of Class

public static class ServiceNetworkFactoryExtensions
{
    public static CombinedResult<ServiceNetworkFactory, InnerServiceNetworkSharingConfigFactory> WithSharingConfig(this ServiceNetworkFactory parentFactory, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null)
    {
        parentFactory.SharingConfigFactory = new InnerServiceNetworkSharingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SharingConfigFactory);
    }

    public static CombinedResult<ServiceNetworkFactory, T1, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1>(this CombinedResult<ServiceNetworkFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSharingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkFactory, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1>(this CombinedResult<T1, ServiceNetworkFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSharingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceNetworkFactory, T1, T2, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2>(this CombinedResult<ServiceNetworkFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkFactory, T2, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2>(this CombinedResult<T1, ServiceNetworkFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkFactory, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2>(this CombinedResult<T1, T2, ServiceNetworkFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceNetworkFactory, T1, T2, T3, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3>(this CombinedResult<ServiceNetworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkFactory, T2, T3, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3>(this CombinedResult<T1, ServiceNetworkFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkFactory, T3, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3>(this CombinedResult<T1, T2, ServiceNetworkFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceNetworkFactory, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceNetworkFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceNetworkFactory, T1, T2, T3, T4, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3, T4>(this CombinedResult<ServiceNetworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceNetworkFactory, T2, T3, T4, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, ServiceNetworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceNetworkFactory, T3, T4, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceNetworkFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceNetworkFactory, T4, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceNetworkFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceNetworkFactory, InnerServiceNetworkSharingConfigFactory> WithSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceNetworkFactory> combinedResult, Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharingConfig(combinedResult.T5, subFactoryAction));
}
