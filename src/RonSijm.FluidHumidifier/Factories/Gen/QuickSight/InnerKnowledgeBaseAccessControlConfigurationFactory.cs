// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseAccessControlConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration Create()
    {
        var accessControlConfigurationResult = CreateAccessControlConfiguration();
        factoryAction?.Invoke(accessControlConfigurationResult);

        return accessControlConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration CreateAccessControlConfiguration()
    {
        var accessControlConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration();

        return accessControlConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseAccessControlConfigurationFactoryExtensions
{
}
