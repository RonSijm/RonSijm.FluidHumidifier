// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerFlowS3LocationFactory(Action<Humidifier.Bedrock.FlowTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.FlowTypes.S3Location>
{

    protected override Humidifier.Bedrock.FlowTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.Bedrock.FlowTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.Bedrock.FlowTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerFlowS3LocationFactoryExtensions
{
}
