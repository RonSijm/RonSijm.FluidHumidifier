// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterComputeLimitsFactory(Action<Humidifier.EMR.ClusterTypes.ComputeLimits> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.ComputeLimits>
{

    protected override Humidifier.EMR.ClusterTypes.ComputeLimits Create()
    {
        var computeLimitsResult = CreateComputeLimits();
        factoryAction?.Invoke(computeLimitsResult);

        return computeLimitsResult;
    }

    private Humidifier.EMR.ClusterTypes.ComputeLimits CreateComputeLimits()
    {
        var computeLimitsResult = new Humidifier.EMR.ClusterTypes.ComputeLimits();

        return computeLimitsResult;
    }

} // End Of Class

public static class InnerClusterComputeLimitsFactoryExtensions
{
}
