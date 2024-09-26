// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServicePlacementConstraintFactory(Action<Humidifier.ECS.ServiceTypes.PlacementConstraint> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.PlacementConstraint>
{

    protected override Humidifier.ECS.ServiceTypes.PlacementConstraint Create()
    {
        var placementConstraintResult = CreatePlacementConstraint();
        factoryAction?.Invoke(placementConstraintResult);

        return placementConstraintResult;
    }

    private Humidifier.ECS.ServiceTypes.PlacementConstraint CreatePlacementConstraint()
    {
        var placementConstraintResult = new Humidifier.ECS.ServiceTypes.PlacementConstraint();

        return placementConstraintResult;
    }

} // End Of Class

public static class InnerServicePlacementConstraintFactoryExtensions
{
}
