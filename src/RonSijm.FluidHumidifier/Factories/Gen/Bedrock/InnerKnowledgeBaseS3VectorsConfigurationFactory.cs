// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseS3VectorsConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration Create()
    {
        var s3VectorsConfigurationResult = CreateS3VectorsConfiguration();
        factoryAction?.Invoke(s3VectorsConfigurationResult);

        return s3VectorsConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration CreateS3VectorsConfiguration()
    {
        var s3VectorsConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration();

        return s3VectorsConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseS3VectorsConfigurationFactoryExtensions
{
}
