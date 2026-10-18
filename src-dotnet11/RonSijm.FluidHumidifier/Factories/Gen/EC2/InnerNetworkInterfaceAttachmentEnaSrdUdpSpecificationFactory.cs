// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification>
{

    protected override Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification Create()
    {
        var enaSrdUdpSpecificationResult = CreateEnaSrdUdpSpecification();
        factoryAction?.Invoke(enaSrdUdpSpecificationResult);

        return enaSrdUdpSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification CreateEnaSrdUdpSpecification()
    {
        var enaSrdUdpSpecificationResult = new Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification();

        return enaSrdUdpSpecificationResult;
    }

} // End Of Class

public static class InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactoryExtensions
{
}
