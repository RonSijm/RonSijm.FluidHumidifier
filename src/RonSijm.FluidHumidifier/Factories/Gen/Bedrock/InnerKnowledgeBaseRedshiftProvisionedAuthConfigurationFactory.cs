// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration Create()
    {
        var redshiftProvisionedAuthConfigurationResult = CreateRedshiftProvisionedAuthConfiguration();
        factoryAction?.Invoke(redshiftProvisionedAuthConfigurationResult);

        return redshiftProvisionedAuthConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration CreateRedshiftProvisionedAuthConfiguration()
    {
        var redshiftProvisionedAuthConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration();

        return redshiftProvisionedAuthConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactoryExtensions
{
}
