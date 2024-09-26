// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerEndpointDetailsFactory(Action<Humidifier.Transfer.ServerTypes.EndpointDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.EndpointDetails>
{

    protected override Humidifier.Transfer.ServerTypes.EndpointDetails Create()
    {
        var endpointDetailsResult = CreateEndpointDetails();
        factoryAction?.Invoke(endpointDetailsResult);

        return endpointDetailsResult;
    }

    private Humidifier.Transfer.ServerTypes.EndpointDetails CreateEndpointDetails()
    {
        var endpointDetailsResult = new Humidifier.Transfer.ServerTypes.EndpointDetails();

        return endpointDetailsResult;
    }

} // End Of Class

public static class InnerServerEndpointDetailsFactoryExtensions
{
}
