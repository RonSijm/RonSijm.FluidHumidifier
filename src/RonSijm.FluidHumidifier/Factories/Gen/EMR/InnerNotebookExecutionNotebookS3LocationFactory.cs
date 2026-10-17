// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerNotebookExecutionNotebookS3LocationFactory(Action<Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location> factoryAction = null) : SubResourceFactory<Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location>
{

    protected override Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location Create()
    {
        var notebookS3LocationResult = CreateNotebookS3Location();
        factoryAction?.Invoke(notebookS3LocationResult);

        return notebookS3LocationResult;
    }

    private Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location CreateNotebookS3Location()
    {
        var notebookS3LocationResult = new Humidifier.EMR.NotebookExecutionTypes.NotebookS3Location();

        return notebookS3LocationResult;
    }

} // End Of Class

public static class InnerNotebookExecutionNotebookS3LocationFactoryExtensions
{
}
