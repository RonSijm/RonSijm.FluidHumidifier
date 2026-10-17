// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLJobCompletionCriteriaFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria Create()
    {
        var autoMLJobCompletionCriteriaResult = CreateAutoMLJobCompletionCriteria();
        factoryAction?.Invoke(autoMLJobCompletionCriteriaResult);

        return autoMLJobCompletionCriteriaResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CreateAutoMLJobCompletionCriteria()
    {
        var autoMLJobCompletionCriteriaResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria();

        return autoMLJobCompletionCriteriaResult;
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLJobCompletionCriteriaFactoryExtensions
{
}
