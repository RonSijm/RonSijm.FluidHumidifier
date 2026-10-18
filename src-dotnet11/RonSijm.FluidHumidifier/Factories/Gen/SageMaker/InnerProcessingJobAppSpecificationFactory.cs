// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobAppSpecificationFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.AppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.AppSpecification>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.AppSpecification Create()
    {
        var appSpecificationResult = CreateAppSpecification();
        factoryAction?.Invoke(appSpecificationResult);

        return appSpecificationResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.AppSpecification CreateAppSpecification()
    {
        var appSpecificationResult = new Humidifier.SageMaker.ProcessingJobTypes.AppSpecification();

        return appSpecificationResult;
    }

} // End Of Class

public static class InnerProcessingJobAppSpecificationFactoryExtensions
{
}
