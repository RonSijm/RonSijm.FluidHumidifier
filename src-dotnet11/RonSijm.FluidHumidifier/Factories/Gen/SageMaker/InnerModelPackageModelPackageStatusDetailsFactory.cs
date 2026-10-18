// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageModelPackageStatusDetailsFactory(Action<Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails Create()
    {
        var modelPackageStatusDetailsResult = CreateModelPackageStatusDetails();
        factoryAction?.Invoke(modelPackageStatusDetailsResult);

        return modelPackageStatusDetailsResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails CreateModelPackageStatusDetails()
    {
        var modelPackageStatusDetailsResult = new Humidifier.SageMaker.ModelPackageTypes.ModelPackageStatusDetails();

        return modelPackageStatusDetailsResult;
    }

} // End Of Class

public static class InnerModelPackageModelPackageStatusDetailsFactoryExtensions
{
}
