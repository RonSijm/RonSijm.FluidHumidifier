// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterControlPlanePlacementFactory(Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ControlPlanePlacement>
{

    protected override Humidifier.EKS.ClusterTypes.ControlPlanePlacement Create()
    {
        var controlPlanePlacementResult = CreateControlPlanePlacement();
        factoryAction?.Invoke(controlPlanePlacementResult);

        return controlPlanePlacementResult;
    }

    private Humidifier.EKS.ClusterTypes.ControlPlanePlacement CreateControlPlanePlacement()
    {
        var controlPlanePlacementResult = new Humidifier.EKS.ClusterTypes.ControlPlanePlacement();

        return controlPlanePlacementResult;
    }

} // End Of Class

public static class InnerClusterControlPlanePlacementFactoryExtensions
{
}
