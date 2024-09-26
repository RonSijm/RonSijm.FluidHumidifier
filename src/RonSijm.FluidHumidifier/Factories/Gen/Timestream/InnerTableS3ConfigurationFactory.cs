// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerTableS3ConfigurationFactory(Action<Humidifier.Timestream.TableTypes.S3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.TableTypes.S3Configuration>
{

    protected override Humidifier.Timestream.TableTypes.S3Configuration Create()
    {
        var s3ConfigurationResult = CreateS3Configuration();
        factoryAction?.Invoke(s3ConfigurationResult);

        return s3ConfigurationResult;
    }

    private Humidifier.Timestream.TableTypes.S3Configuration CreateS3Configuration()
    {
        var s3ConfigurationResult = new Humidifier.Timestream.TableTypes.S3Configuration();

        return s3ConfigurationResult;
    }

} // End Of Class

public static class InnerTableS3ConfigurationFactoryExtensions
{
}
