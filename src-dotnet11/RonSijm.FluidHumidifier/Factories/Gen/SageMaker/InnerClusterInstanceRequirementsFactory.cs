// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterInstanceRequirementsFactory(Action<Humidifier.SageMaker.ClusterTypes.InstanceRequirements> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.InstanceRequirements>
{

    protected override Humidifier.SageMaker.ClusterTypes.InstanceRequirements Create()
    {
        var instanceRequirementsResult = CreateInstanceRequirements();
        factoryAction?.Invoke(instanceRequirementsResult);

        return instanceRequirementsResult;
    }

    private Humidifier.SageMaker.ClusterTypes.InstanceRequirements CreateInstanceRequirements()
    {
        var instanceRequirementsResult = new Humidifier.SageMaker.ClusterTypes.InstanceRequirements();

        return instanceRequirementsResult;
    }

} // End Of Class

public static class InnerClusterInstanceRequirementsFactoryExtensions
{
}
