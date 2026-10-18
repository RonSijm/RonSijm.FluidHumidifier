// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobRedshiftDatasetDefinitionFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition Create()
    {
        var redshiftDatasetDefinitionResult = CreateRedshiftDatasetDefinition();
        factoryAction?.Invoke(redshiftDatasetDefinitionResult);

        return redshiftDatasetDefinitionResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition CreateRedshiftDatasetDefinition()
    {
        var redshiftDatasetDefinitionResult = new Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition();

        return redshiftDatasetDefinitionResult;
    }

} // End Of Class

public static class InnerProcessingJobRedshiftDatasetDefinitionFactoryExtensions
{
}
