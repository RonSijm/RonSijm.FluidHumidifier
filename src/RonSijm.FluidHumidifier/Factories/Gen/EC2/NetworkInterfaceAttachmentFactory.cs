// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInterfaceAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInterfaceAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInterfaceAttachment>(resourceName)
{

    internal InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory EnaSrdSpecificationFactory { get; set; }

    protected override Humidifier.EC2.NetworkInterfaceAttachment Create()
    {
        var networkInterfaceAttachmentResult = CreateNetworkInterfaceAttachment();
        factoryAction?.Invoke(networkInterfaceAttachmentResult);

        return networkInterfaceAttachmentResult;
    }

    private Humidifier.EC2.NetworkInterfaceAttachment CreateNetworkInterfaceAttachment()
    {
        var networkInterfaceAttachmentResult = new Humidifier.EC2.NetworkInterfaceAttachment
        {
            GivenName = InputResourceName,
        };

        return networkInterfaceAttachmentResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkInterfaceAttachment result)
    {
        base.CreateChildren(result);

        result.EnaSrdSpecification ??= EnaSrdSpecificationFactory?.Build();
    }

} // End Of Class

public static class NetworkInterfaceAttachmentFactoryExtensions
{
    public static CombinedResult<NetworkInterfaceAttachmentFactory, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification(this NetworkInterfaceAttachmentFactory parentFactory, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null)
    {
        parentFactory.EnaSrdSpecificationFactory = new InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnaSrdSpecificationFactory);
    }

    public static CombinedResult<NetworkInterfaceAttachmentFactory, T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1>(this CombinedResult<NetworkInterfaceAttachmentFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInterfaceAttachmentFactory, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1>(this CombinedResult<T1, NetworkInterfaceAttachmentFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2>(this CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2>(this CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2>(this CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3>(this CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3>(this CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3>(this CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInterfaceAttachmentFactory, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkInterfaceAttachmentFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3, T4>(this CombinedResult<NetworkInterfaceAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3, T4>(this CombinedResult<T1, NetworkInterfaceAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkInterfaceAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInterfaceAttachmentFactory, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkInterfaceAttachmentFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkInterfaceAttachmentFactory, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> WithEnaSrdSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkInterfaceAttachmentFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdSpecification(combinedResult.T5, subFactoryAction));
}
