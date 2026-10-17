// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLJobObjectiveFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective Create()
    {
        var autoMLJobObjectiveResult = CreateAutoMLJobObjective();
        factoryAction?.Invoke(autoMLJobObjectiveResult);

        return autoMLJobObjectiveResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective CreateAutoMLJobObjective()
    {
        var autoMLJobObjectiveResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective();

        return autoMLJobObjectiveResult;
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLJobObjectiveFactoryExtensions
{
}
