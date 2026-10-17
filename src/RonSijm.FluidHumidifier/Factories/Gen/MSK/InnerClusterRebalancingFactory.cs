// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterRebalancingFactory(Action<Humidifier.MSK.ClusterTypes.Rebalancing> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Rebalancing>
{

    protected override Humidifier.MSK.ClusterTypes.Rebalancing Create()
    {
        var rebalancingResult = CreateRebalancing();
        factoryAction?.Invoke(rebalancingResult);

        return rebalancingResult;
    }

    private Humidifier.MSK.ClusterTypes.Rebalancing CreateRebalancing()
    {
        var rebalancingResult = new Humidifier.MSK.ClusterTypes.Rebalancing();

        return rebalancingResult;
    }

} // End Of Class

public static class InnerClusterRebalancingFactoryExtensions
{
}
