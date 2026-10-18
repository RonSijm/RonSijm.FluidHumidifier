// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionConstraintsResourceFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource Create()
    {
        var constraintsResourceResult = CreateConstraintsResource();
        factoryAction?.Invoke(constraintsResourceResult);

        return constraintsResourceResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource CreateConstraintsResource()
    {
        var constraintsResourceResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource();

        return constraintsResourceResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionConstraintsResourceFactoryExtensions
{
}
