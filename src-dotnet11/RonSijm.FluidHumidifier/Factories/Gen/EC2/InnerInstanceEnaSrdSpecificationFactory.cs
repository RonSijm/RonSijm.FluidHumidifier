// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceEnaSrdSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.EnaSrdSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.EnaSrdSpecification>
{

    internal InnerInstanceEnaSrdUdpSpecificationFactory EnaSrdUdpSpecificationFactory { get; set; }

    protected override Humidifier.EC2.InstanceTypes.EnaSrdSpecification Create()
    {
        var enaSrdSpecificationResult = CreateEnaSrdSpecification();
        factoryAction?.Invoke(enaSrdSpecificationResult);

        return enaSrdSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.EnaSrdSpecification CreateEnaSrdSpecification()
    {
        var enaSrdSpecificationResult = new Humidifier.EC2.InstanceTypes.EnaSrdSpecification();

        return enaSrdSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EC2.InstanceTypes.EnaSrdSpecification result)
    {
        base.CreateChildren(result);

        result.EnaSrdUdpSpecification ??= EnaSrdUdpSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceEnaSrdSpecificationFactoryExtensions
{
    public static CombinedResult<InnerInstanceEnaSrdSpecificationFactory, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification(this InnerInstanceEnaSrdSpecificationFactory parentFactory, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null)
    {
        parentFactory.EnaSrdUdpSpecificationFactory = new InnerInstanceEnaSrdUdpSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnaSrdUdpSpecificationFactory);
    }

    public static CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1>(this CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1>(this CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2>(this CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2, T3, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2, T3, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory, T3, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstanceEnaSrdSpecificationFactory, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2, T3, T4, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<InnerInstanceEnaSrdSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2, T3, T4, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceEnaSrdSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory, T3, T4, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceEnaSrdSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstanceEnaSrdSpecificationFactory, T4, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceEnaSrdSpecificationFactory, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceEnaSrdSpecificationFactory, InnerInstanceEnaSrdUdpSpecificationFactory> WithEnaSrdUdpSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceEnaSrdSpecificationFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnaSrdUdpSpecification(combinedResult.T5, subFactoryAction).T2);
}
