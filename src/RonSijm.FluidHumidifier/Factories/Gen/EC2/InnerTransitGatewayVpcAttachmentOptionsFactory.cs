// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayVpcAttachmentOptionsFactory(Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options>
{

    protected override Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options Create()
    {
        var optionsResult = CreateOptions();
        factoryAction?.Invoke(optionsResult);

        return optionsResult;
    }

    private Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options CreateOptions()
    {
        var optionsResult = new Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options();

        return optionsResult;
    }

} // End Of Class

public static class InnerTransitGatewayVpcAttachmentOptionsFactoryExtensions
{
}
