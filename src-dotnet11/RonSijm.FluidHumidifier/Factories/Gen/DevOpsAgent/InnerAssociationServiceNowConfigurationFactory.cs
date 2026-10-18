// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationServiceNowConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration Create()
    {
        var serviceNowConfigurationResult = CreateServiceNowConfiguration();
        factoryAction?.Invoke(serviceNowConfigurationResult);

        return serviceNowConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration CreateServiceNowConfiguration()
    {
        var serviceNowConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration();

        return serviceNowConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationServiceNowConfigurationFactoryExtensions
{
}
