// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorClientCredentialsGrantDetailsFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails Create()
    {
        var clientCredentialsGrantDetailsResult = CreateClientCredentialsGrantDetails();
        factoryAction?.Invoke(clientCredentialsGrantDetailsResult);

        return clientCredentialsGrantDetailsResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails CreateClientCredentialsGrantDetails()
    {
        var clientCredentialsGrantDetailsResult = new Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails();

        return clientCredentialsGrantDetailsResult;
    }

} // End Of Class

public static class InnerActionConnectorClientCredentialsGrantDetailsFactoryExtensions
{
}
