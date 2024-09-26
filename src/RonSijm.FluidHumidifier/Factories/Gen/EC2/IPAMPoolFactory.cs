// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMPoolFactory(string resourceName = null, Action<Humidifier.EC2.IPAMPool> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMPool>(resourceName)
{

    internal List<InnerIPAMPoolProvisionedCidrFactory> ProvisionedCidrsFactories { get; set; } = [];

    internal InnerIPAMPoolSourceResourceFactory SourceResourceFactory { get; set; }

    protected override Humidifier.EC2.IPAMPool Create()
    {
        var iPAMPoolResult = CreateIPAMPool();
        factoryAction?.Invoke(iPAMPoolResult);

        return iPAMPoolResult;
    }

    private Humidifier.EC2.IPAMPool CreateIPAMPool()
    {
        var iPAMPoolResult = new Humidifier.EC2.IPAMPool
        {
            GivenName = InputResourceName,
        };

        return iPAMPoolResult;
    }
    public override void CreateChildren(Humidifier.EC2.IPAMPool result)
    {
        base.CreateChildren(result);

        result.ProvisionedCidrs = ProvisionedCidrsFactories.Any() ? ProvisionedCidrsFactories.Select(x => x.Build()).ToList() : null;
        result.SourceResource ??= SourceResourceFactory?.Build();
    }

} // End Of Class

public static class IPAMPoolFactoryExtensions
{
    public static CombinedResult<IPAMPoolFactory, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs(this IPAMPoolFactory parentFactory, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null)
    {
        var factory = new InnerIPAMPoolProvisionedCidrFactory(subFactoryAction);
        parentFactory.ProvisionedCidrsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPAMPoolFactory, InnerIPAMPoolSourceResourceFactory> WithSourceResource(this IPAMPoolFactory parentFactory, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null)
    {
        parentFactory.SourceResourceFactory = new InnerIPAMPoolSourceResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceResourceFactory);
    }

    public static CombinedResult<IPAMPoolFactory, T1, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1>(this CombinedResult<IPAMPoolFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1>(this CombinedResult<T1, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2>(this CombinedResult<IPAMPoolFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2>(this CombinedResult<T1, IPAMPoolFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2>(this CombinedResult<T1, T2, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, T3, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3>(this CombinedResult<IPAMPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, T3, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3>(this CombinedResult<T1, IPAMPoolFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, T3, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3>(this CombinedResult<T1, T2, IPAMPoolFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMPoolFactory, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, T3, T4, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3, T4>(this CombinedResult<IPAMPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, T3, T4, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3, T4>(this CombinedResult<T1, IPAMPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, T3, T4, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMPoolFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMPoolFactory, T4, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMPoolFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IPAMPoolFactory, InnerIPAMPoolProvisionedCidrFactory> WithProvisionedCidrs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCidrs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1>(this CombinedResult<IPAMPoolFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1>(this CombinedResult<T1, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2>(this CombinedResult<IPAMPoolFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2>(this CombinedResult<T1, IPAMPoolFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2>(this CombinedResult<T1, T2, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, T3, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3>(this CombinedResult<IPAMPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, T3, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3>(this CombinedResult<T1, IPAMPoolFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, T3, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3>(this CombinedResult<T1, T2, IPAMPoolFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMPoolFactory, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IPAMPoolFactory, T1, T2, T3, T4, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3, T4>(this CombinedResult<IPAMPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMPoolFactory, T2, T3, T4, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3, T4>(this CombinedResult<T1, IPAMPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMPoolFactory, T3, T4, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMPoolFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMPoolFactory, T4, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMPoolFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IPAMPoolFactory, InnerIPAMPoolSourceResourceFactory> WithSourceResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMPoolFactory> combinedResult, Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceResource(combinedResult.T5, subFactoryAction));
}
