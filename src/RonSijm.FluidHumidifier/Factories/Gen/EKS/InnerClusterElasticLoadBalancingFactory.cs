// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterElasticLoadBalancingFactory(Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing>
{

    protected override Humidifier.EKS.ClusterTypes.ElasticLoadBalancing Create()
    {
        var elasticLoadBalancingResult = CreateElasticLoadBalancing();
        factoryAction?.Invoke(elasticLoadBalancingResult);

        return elasticLoadBalancingResult;
    }

    private Humidifier.EKS.ClusterTypes.ElasticLoadBalancing CreateElasticLoadBalancing()
    {
        var elasticLoadBalancingResult = new Humidifier.EKS.ClusterTypes.ElasticLoadBalancing();

        return elasticLoadBalancingResult;
    }

} // End Of Class

public static class InnerClusterElasticLoadBalancingFactoryExtensions
{
}
