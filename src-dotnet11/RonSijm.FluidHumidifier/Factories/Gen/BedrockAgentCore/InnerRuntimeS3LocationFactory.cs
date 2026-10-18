// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeS3LocationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.S3Location>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerRuntimeS3LocationFactoryExtensions
{
}
