// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerQuerySuggestionsBlockListS3PathFactory(Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path>
{

    protected override Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path Create()
    {
        var s3PathResult = CreateS3Path();
        factoryAction?.Invoke(s3PathResult);

        return s3PathResult;
    }

    private Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path CreateS3Path()
    {
        var s3PathResult = new Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path();

        return s3PathResult;
    }

} // End Of Class

public static class InnerQuerySuggestionsBlockListS3PathFactoryExtensions
{
}
