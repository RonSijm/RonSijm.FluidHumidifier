// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionConstraintsResourceFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource Create()
    {
        var constraintsResourceResult = CreateConstraintsResource();
        factoryAction?.Invoke(constraintsResourceResult);

        return constraintsResourceResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource CreateConstraintsResource()
    {
        var constraintsResourceResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource();

        return constraintsResourceResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionConstraintsResourceFactoryExtensions
{
}
