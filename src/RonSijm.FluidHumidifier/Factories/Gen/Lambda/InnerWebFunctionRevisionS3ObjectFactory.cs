// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionS3ObjectFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.S3Object>
{

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.S3Object Create()
    {
        var s3ObjectResult = CreateS3Object();
        factoryAction?.Invoke(s3ObjectResult);

        return s3ObjectResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.S3Object CreateS3Object()
    {
        var s3ObjectResult = new Humidifier.Lambda.WebFunctionRevisionTypes.S3Object();

        return s3ObjectResult;
    }

} // End Of Class

public static class InnerWebFunctionRevisionS3ObjectFactoryExtensions
{
}
