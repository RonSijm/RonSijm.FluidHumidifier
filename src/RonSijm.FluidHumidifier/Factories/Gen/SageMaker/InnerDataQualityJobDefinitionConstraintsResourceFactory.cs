// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionConstraintsResourceFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource Create()
    {
        var constraintsResourceResult = CreateConstraintsResource();
        factoryAction?.Invoke(constraintsResourceResult);

        return constraintsResourceResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource CreateConstraintsResource()
    {
        var constraintsResourceResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource();

        return constraintsResourceResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionConstraintsResourceFactoryExtensions
{
}
