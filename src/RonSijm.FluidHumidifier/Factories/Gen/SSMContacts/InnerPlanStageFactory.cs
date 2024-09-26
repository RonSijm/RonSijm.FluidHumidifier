// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class InnerPlanStageFactory(Action<Humidifier.SSMContacts.PlanTypes.Stage> factoryAction = null) : SubResourceFactory<Humidifier.SSMContacts.PlanTypes.Stage>
{

    protected override Humidifier.SSMContacts.PlanTypes.Stage Create()
    {
        var stageResult = CreateStage();
        factoryAction?.Invoke(stageResult);

        return stageResult;
    }

    private Humidifier.SSMContacts.PlanTypes.Stage CreateStage()
    {
        var stageResult = new Humidifier.SSMContacts.PlanTypes.Stage();

        return stageResult;
    }

} // End Of Class

public static class InnerPlanStageFactoryExtensions
{
}
