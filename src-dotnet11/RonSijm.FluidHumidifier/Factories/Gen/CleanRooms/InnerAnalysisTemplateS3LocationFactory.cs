// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateS3LocationFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateS3LocationFactoryExtensions
{
}
