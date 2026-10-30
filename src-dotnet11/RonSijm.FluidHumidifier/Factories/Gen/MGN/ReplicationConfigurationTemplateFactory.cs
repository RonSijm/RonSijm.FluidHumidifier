// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class ReplicationConfigurationTemplateFactory(string resourceName = null, Action<Humidifier.MGN.ReplicationConfigurationTemplate> factoryAction = null) : ResourceFactory<Humidifier.MGN.ReplicationConfigurationTemplate>(resourceName)
{

    protected override Humidifier.MGN.ReplicationConfigurationTemplate Create()
    {
        var replicationConfigurationTemplateResult = CreateReplicationConfigurationTemplate();
        factoryAction?.Invoke(replicationConfigurationTemplateResult);

        return replicationConfigurationTemplateResult;
    }

    private Humidifier.MGN.ReplicationConfigurationTemplate CreateReplicationConfigurationTemplate()
    {
        var replicationConfigurationTemplateResult = new Humidifier.MGN.ReplicationConfigurationTemplate
        {
            GivenName = InputResourceName,
        };

        return replicationConfigurationTemplateResult;
    }

} // End Of Class

public static class ReplicationConfigurationTemplateFactoryExtensions
{
}
