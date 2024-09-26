// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class IPSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.IPSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.IPSet>(resourceName)
{

    internal List<InnerIPSetIPSetDescriptorFactory> IPSetDescriptorsFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.IPSet Create()
    {
        var iPSetResult = CreateIPSet();
        factoryAction?.Invoke(iPSetResult);

        return iPSetResult;
    }

    private Humidifier.WAFRegional.IPSet CreateIPSet()
    {
        var iPSetResult = new Humidifier.WAFRegional.IPSet
        {
            GivenName = InputResourceName,
        };

        return iPSetResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.IPSet result)
    {
        base.CreateChildren(result);

        result.IPSetDescriptors = IPSetDescriptorsFactories.Any() ? IPSetDescriptorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IPSetFactoryExtensions
{
    public static CombinedResult<IPSetFactory, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors(this IPSetFactory parentFactory, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null)
    {
        var factory = new InnerIPSetIPSetDescriptorFactory(subFactoryAction);
        parentFactory.IPSetDescriptorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPSetFactory, T1, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1>(this CombinedResult<IPSetFactory, T1> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1>(this CombinedResult<T1, IPSetFactory> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2>(this CombinedResult<IPSetFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2>(this CombinedResult<T1, IPSetFactory, T2> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2>(this CombinedResult<T1, T2, IPSetFactory> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, T3, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3>(this CombinedResult<IPSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, T3, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3>(this CombinedResult<T1, IPSetFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, T3, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, IPSetFactory, T3> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPSetFactory, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPSetFactory> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, T3, T4, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3, T4>(this CombinedResult<IPSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, T3, T4, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, IPSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, T3, T4, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPSetFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPSetFactory, T4, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPSetFactory, T4> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IPSetFactory, InnerIPSetIPSetDescriptorFactory> WithIPSetDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPSetFactory> combinedResult, Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetDescriptors(combinedResult.T5, subFactoryAction));
}
