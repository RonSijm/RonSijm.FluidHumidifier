// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationAzureConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration Create()
    {
        var azureConfigurationResult = CreateAzureConfiguration();
        factoryAction?.Invoke(azureConfigurationResult);

        return azureConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration CreateAzureConfiguration()
    {
        var azureConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration();

        return azureConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationAzureConfigurationFactoryExtensions
{
}
