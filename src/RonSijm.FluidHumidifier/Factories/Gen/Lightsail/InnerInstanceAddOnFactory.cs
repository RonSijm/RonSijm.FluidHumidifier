// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceAddOnFactory(Action<Humidifier.Lightsail.InstanceTypes.AddOn> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.AddOn>
{

    internal InnerInstanceAutoSnapshotAddOnFactory AutoSnapshotAddOnRequestFactory { get; set; }

    protected override Humidifier.Lightsail.InstanceTypes.AddOn Create()
    {
        var addOnResult = CreateAddOn();
        factoryAction?.Invoke(addOnResult);

        return addOnResult;
    }

    private Humidifier.Lightsail.InstanceTypes.AddOn CreateAddOn()
    {
        var addOnResult = new Humidifier.Lightsail.InstanceTypes.AddOn();

        return addOnResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.InstanceTypes.AddOn result)
    {
        base.CreateChildren(result);

        result.AutoSnapshotAddOnRequest ??= AutoSnapshotAddOnRequestFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceAddOnFactoryExtensions
{
    public static CombinedResult<InnerInstanceAddOnFactory, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest(this InnerInstanceAddOnFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null)
    {
        parentFactory.AutoSnapshotAddOnRequestFactory = new InnerInstanceAutoSnapshotAddOnFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoSnapshotAddOnRequestFactory);
    }

    public static CombinedResult<InnerInstanceAddOnFactory, T1, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1>(this CombinedResult<InnerInstanceAddOnFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAddOnFactory, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1>(this CombinedResult<T1, InnerInstanceAddOnFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceAddOnFactory, T1, T2, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<InnerInstanceAddOnFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAddOnFactory, T2, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<T1, InnerInstanceAddOnFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAddOnFactory, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<T1, T2, InnerInstanceAddOnFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceAddOnFactory, T1, T2, T3, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<InnerInstanceAddOnFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAddOnFactory, T2, T3, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, InnerInstanceAddOnFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAddOnFactory, T3, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceAddOnFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceAddOnFactory, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceAddOnFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceAddOnFactory, T1, T2, T3, T4, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<InnerInstanceAddOnFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAddOnFactory, T2, T3, T4, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceAddOnFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAddOnFactory, T3, T4, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceAddOnFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceAddOnFactory, T4, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceAddOnFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceAddOnFactory, InnerInstanceAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceAddOnFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T5, subFactoryAction));
}
