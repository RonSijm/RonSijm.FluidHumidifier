// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageFileSourceFactory(Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.FileSource>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.FileSource Create()
    {
        var fileSourceResult = CreateFileSource();
        factoryAction?.Invoke(fileSourceResult);

        return fileSourceResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.FileSource CreateFileSource()
    {
        var fileSourceResult = new Humidifier.SageMaker.ModelPackageTypes.FileSource();

        return fileSourceResult;
    }

} // End Of Class

public static class InnerModelPackageFileSourceFactoryExtensions
{
}
