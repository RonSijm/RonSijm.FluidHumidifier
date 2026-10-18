// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterScoringStrategyFactory(Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ScoringStrategy>
{

    protected override Humidifier.EKS.ClusterTypes.ScoringStrategy Create()
    {
        var scoringStrategyResult = CreateScoringStrategy();
        factoryAction?.Invoke(scoringStrategyResult);

        return scoringStrategyResult;
    }

    private Humidifier.EKS.ClusterTypes.ScoringStrategy CreateScoringStrategy()
    {
        var scoringStrategyResult = new Humidifier.EKS.ClusterTypes.ScoringStrategy();

        return scoringStrategyResult;
    }

} // End Of Class

public static class InnerClusterScoringStrategyFactoryExtensions
{
}
