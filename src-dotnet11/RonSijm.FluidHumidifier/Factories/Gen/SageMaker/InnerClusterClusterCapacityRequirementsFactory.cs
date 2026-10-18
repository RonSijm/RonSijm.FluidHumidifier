// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterCapacityRequirementsFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements Create()
    {
        var clusterCapacityRequirementsResult = CreateClusterCapacityRequirements();
        factoryAction?.Invoke(clusterCapacityRequirementsResult);

        return clusterCapacityRequirementsResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements CreateClusterCapacityRequirements()
    {
        var clusterCapacityRequirementsResult = new Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements();

        return clusterCapacityRequirementsResult;
    }

} // End Of Class

public static class InnerClusterClusterCapacityRequirementsFactoryExtensions
{
}
