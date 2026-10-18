// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointTagSpecificationFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification Create()
    {
        var tagSpecificationResult = CreateTagSpecification();
        factoryAction?.Invoke(tagSpecificationResult);

        return tagSpecificationResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification CreateTagSpecification()
    {
        var tagSpecificationResult = new Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification();

        return tagSpecificationResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointTagSpecificationFactoryExtensions
{
}
