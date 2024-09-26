// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayMulticastDomainOptionsFactory(Action<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options>
{

    protected override Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options Create()
    {
        var optionsResult = CreateOptions();
        factoryAction?.Invoke(optionsResult);

        return optionsResult;
    }

    private Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options CreateOptions()
    {
        var optionsResult = new Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options();

        return optionsResult;
    }

} // End Of Class

public static class InnerTransitGatewayMulticastDomainOptionsFactoryExtensions
{
}
