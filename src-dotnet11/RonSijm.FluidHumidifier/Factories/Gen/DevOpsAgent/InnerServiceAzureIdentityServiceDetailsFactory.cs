// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceAzureIdentityServiceDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails Create()
    {
        var azureIdentityServiceDetailsResult = CreateAzureIdentityServiceDetails();
        factoryAction?.Invoke(azureIdentityServiceDetailsResult);

        return azureIdentityServiceDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails CreateAzureIdentityServiceDetails()
    {
        var azureIdentityServiceDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails();

        return azureIdentityServiceDetailsResult;
    }

} // End Of Class

public static class InnerServiceAzureIdentityServiceDetailsFactoryExtensions
{
}
