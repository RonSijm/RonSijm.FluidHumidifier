// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobFileSystemDataSourceFactory(Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource Create()
    {
        var fileSystemDataSourceResult = CreateFileSystemDataSource();
        factoryAction?.Invoke(fileSystemDataSourceResult);

        return fileSystemDataSourceResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource CreateFileSystemDataSource()
    {
        var fileSystemDataSourceResult = new Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource();

        return fileSystemDataSourceResult;
    }

} // End Of Class

public static class InnerTrainingJobFileSystemDataSourceFactoryExtensions
{
}
