// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification>
{

    internal InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory EnaSrdUdpSpecificationFactory { get; set; }

    protected override Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification Create()
    {
        var enaSrdSpecificationResult = CreateEnaSrdSpecification();
        factoryAction?.Invoke(enaSrdSpecificationResult);

        return enaSrdSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification CreateEnaSrdSpecification()
    {
        var enaSrdSpecificationResult = new Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification();

        return enaSrdSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdSpecification result)
    {
        base.CreateChildren(result);

        result.EnaSrdUdpSpecification ??= EnaSrdUdpSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactoryExtensions
{
    public static CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification(this InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory parentFactory, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null)
    {
        parentFactory.EnaSrdUdpSpecificationFactory = new InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnaSrdUdpSpecificationFactory);
    }

    public static CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1>(this CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1>(this CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T3, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T4, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory, InnerNetworkInterfaceAttachmentEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerNetworkInterfaceAttachmentEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.NetworkInterfaceAttachmentTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T5, subFactoryAction));
}
