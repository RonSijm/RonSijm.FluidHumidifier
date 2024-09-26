// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayAttachmentOptionsFactory(Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayAttachmentTypes.Options>
{

    protected override Humidifier.EC2.TransitGatewayAttachmentTypes.Options Create()
    {
        var optionsResult = CreateOptions();
        factoryAction?.Invoke(optionsResult);

        return optionsResult;
    }

    private Humidifier.EC2.TransitGatewayAttachmentTypes.Options CreateOptions()
    {
        var optionsResult = new Humidifier.EC2.TransitGatewayAttachmentTypes.Options();

        return optionsResult;
    }

} // End Of Class

public static class InnerTransitGatewayAttachmentOptionsFactoryExtensions
{
}
