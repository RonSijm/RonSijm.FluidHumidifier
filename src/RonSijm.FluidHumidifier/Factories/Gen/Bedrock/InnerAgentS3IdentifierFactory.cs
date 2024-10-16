// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentS3IdentifierFactory(Action<Humidifier.Bedrock.AgentTypes.S3Identifier> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.S3Identifier>
{

    protected override Humidifier.Bedrock.AgentTypes.S3Identifier Create()
    {
        var s3IdentifierResult = CreateS3Identifier();
        factoryAction?.Invoke(s3IdentifierResult);

        return s3IdentifierResult;
    }

    private Humidifier.Bedrock.AgentTypes.S3Identifier CreateS3Identifier()
    {
        var s3IdentifierResult = new Humidifier.Bedrock.AgentTypes.S3Identifier();

        return s3IdentifierResult;
    }

} // End Of Class

public static class InnerAgentS3IdentifierFactoryExtensions
{
}
