// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerNotebookExecutionOutputNotebookS3LocationFactory(Action<Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location> factoryAction = null) : SubResourceFactory<Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location>
{

    protected override Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location Create()
    {
        var outputNotebookS3LocationResult = CreateOutputNotebookS3Location();
        factoryAction?.Invoke(outputNotebookS3LocationResult);

        return outputNotebookS3LocationResult;
    }

    private Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location CreateOutputNotebookS3Location()
    {
        var outputNotebookS3LocationResult = new Humidifier.EMR.NotebookExecutionTypes.OutputNotebookS3Location();

        return outputNotebookS3LocationResult;
    }

} // End Of Class

public static class InnerNotebookExecutionOutputNotebookS3LocationFactoryExtensions
{
}
