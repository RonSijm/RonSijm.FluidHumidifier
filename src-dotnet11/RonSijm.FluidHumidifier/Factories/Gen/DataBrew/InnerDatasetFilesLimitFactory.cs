// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetFilesLimitFactory(Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.FilesLimit>
{

    protected override Humidifier.DataBrew.DatasetTypes.FilesLimit Create()
    {
        var filesLimitResult = CreateFilesLimit();
        factoryAction?.Invoke(filesLimitResult);

        return filesLimitResult;
    }

    private Humidifier.DataBrew.DatasetTypes.FilesLimit CreateFilesLimit()
    {
        var filesLimitResult = new Humidifier.DataBrew.DatasetTypes.FilesLimit();

        return filesLimitResult;
    }

} // End Of Class

public static class InnerDatasetFilesLimitFactoryExtensions
{
}
