// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerExportImageTaskS3ExportLocationFactory(Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation>
{

    protected override Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation Create()
    {
        var s3ExportLocationResult = CreateS3ExportLocation();
        factoryAction?.Invoke(s3ExportLocationResult);

        return s3ExportLocationResult;
    }

    private Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation CreateS3ExportLocation()
    {
        var s3ExportLocationResult = new Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation();

        return s3ExportLocationResult;
    }

} // End Of Class

public static class InnerExportImageTaskS3ExportLocationFactoryExtensions
{
}
