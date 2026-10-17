// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class InnerWorkgroupEndpointFactory(Action<Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint> factoryAction = null) : SubResourceFactory<Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint>
{

    protected override Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.RedshiftServerless.WorkgroupTypes.Endpoint();

        return endpointResult;
    }

} // End Of Class

public static class InnerWorkgroupEndpointFactoryExtensions
{
}
