// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionConstraintsResourceFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource Create()
    {
        var constraintsResourceResult = CreateConstraintsResource();
        factoryAction?.Invoke(constraintsResourceResult);

        return constraintsResourceResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource CreateConstraintsResource()
    {
        var constraintsResourceResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ConstraintsResource();

        return constraintsResourceResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionConstraintsResourceFactoryExtensions
{
}
