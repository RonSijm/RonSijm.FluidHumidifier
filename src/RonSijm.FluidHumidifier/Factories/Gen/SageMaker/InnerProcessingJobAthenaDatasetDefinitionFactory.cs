// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobAthenaDatasetDefinitionFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition Create()
    {
        var athenaDatasetDefinitionResult = CreateAthenaDatasetDefinition();
        factoryAction?.Invoke(athenaDatasetDefinitionResult);

        return athenaDatasetDefinitionResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition CreateAthenaDatasetDefinition()
    {
        var athenaDatasetDefinitionResult = new Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition();

        return athenaDatasetDefinitionResult;
    }

} // End Of Class

public static class InnerProcessingJobAthenaDatasetDefinitionFactoryExtensions
{
}
