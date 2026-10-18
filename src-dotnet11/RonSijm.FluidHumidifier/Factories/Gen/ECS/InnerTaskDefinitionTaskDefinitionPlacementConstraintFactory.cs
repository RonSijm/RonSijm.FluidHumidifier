// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionTaskDefinitionPlacementConstraintFactory(Action<Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint Create()
    {
        var taskDefinitionPlacementConstraintResult = CreateTaskDefinitionPlacementConstraint();
        factoryAction?.Invoke(taskDefinitionPlacementConstraintResult);

        return taskDefinitionPlacementConstraintResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint CreateTaskDefinitionPlacementConstraint()
    {
        var taskDefinitionPlacementConstraintResult = new Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint();

        return taskDefinitionPlacementConstraintResult;
    }

} // End Of Class

public static class InnerTaskDefinitionTaskDefinitionPlacementConstraintFactoryExtensions
{
}
