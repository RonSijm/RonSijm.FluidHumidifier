// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterAutoTerminationPolicyFactory(Action<Humidifier.EMR.ClusterTypes.AutoTerminationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.AutoTerminationPolicy>
{

    protected override Humidifier.EMR.ClusterTypes.AutoTerminationPolicy Create()
    {
        var autoTerminationPolicyResult = CreateAutoTerminationPolicy();
        factoryAction?.Invoke(autoTerminationPolicyResult);

        return autoTerminationPolicyResult;
    }

    private Humidifier.EMR.ClusterTypes.AutoTerminationPolicy CreateAutoTerminationPolicy()
    {
        var autoTerminationPolicyResult = new Humidifier.EMR.ClusterTypes.AutoTerminationPolicy();

        return autoTerminationPolicyResult;
    }

} // End Of Class

public static class InnerClusterAutoTerminationPolicyFactoryExtensions
{
}
