// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration Create()
    {
        var redshiftServerlessAuthConfigurationResult = CreateRedshiftServerlessAuthConfiguration();
        factoryAction?.Invoke(redshiftServerlessAuthConfigurationResult);

        return redshiftServerlessAuthConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration CreateRedshiftServerlessAuthConfiguration()
    {
        var redshiftServerlessAuthConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration();

        return redshiftServerlessAuthConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactoryExtensions
{
}
