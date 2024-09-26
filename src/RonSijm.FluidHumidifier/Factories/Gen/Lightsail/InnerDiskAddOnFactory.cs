// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDiskAddOnFactory(Action<Humidifier.Lightsail.DiskTypes.AddOn> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DiskTypes.AddOn>
{

    internal InnerDiskAutoSnapshotAddOnFactory AutoSnapshotAddOnRequestFactory { get; set; }

    protected override Humidifier.Lightsail.DiskTypes.AddOn Create()
    {
        var addOnResult = CreateAddOn();
        factoryAction?.Invoke(addOnResult);

        return addOnResult;
    }

    private Humidifier.Lightsail.DiskTypes.AddOn CreateAddOn()
    {
        var addOnResult = new Humidifier.Lightsail.DiskTypes.AddOn();

        return addOnResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.DiskTypes.AddOn result)
    {
        base.CreateChildren(result);

        result.AutoSnapshotAddOnRequest ??= AutoSnapshotAddOnRequestFactory?.Build();
    }

} // End Of Class

public static class InnerDiskAddOnFactoryExtensions
{
    public static CombinedResult<InnerDiskAddOnFactory, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest(this InnerDiskAddOnFactory parentFactory, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null)
    {
        parentFactory.AutoSnapshotAddOnRequestFactory = new InnerDiskAutoSnapshotAddOnFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoSnapshotAddOnRequestFactory);
    }

    public static CombinedResult<InnerDiskAddOnFactory, T1, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1>(this CombinedResult<InnerDiskAddOnFactory, T1> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDiskAddOnFactory, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1>(this CombinedResult<T1, InnerDiskAddOnFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDiskAddOnFactory, T1, T2, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<InnerDiskAddOnFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDiskAddOnFactory, T2, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<T1, InnerDiskAddOnFactory, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDiskAddOnFactory, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2>(this CombinedResult<T1, T2, InnerDiskAddOnFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDiskAddOnFactory, T1, T2, T3, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<InnerDiskAddOnFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDiskAddOnFactory, T2, T3, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, InnerDiskAddOnFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDiskAddOnFactory, T3, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerDiskAddOnFactory, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDiskAddOnFactory, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDiskAddOnFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDiskAddOnFactory, T1, T2, T3, T4, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<InnerDiskAddOnFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDiskAddOnFactory, T2, T3, T4, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerDiskAddOnFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDiskAddOnFactory, T3, T4, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDiskAddOnFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDiskAddOnFactory, T4, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDiskAddOnFactory, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDiskAddOnFactory, InnerDiskAutoSnapshotAddOnFactory> WithAutoSnapshotAddOnRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDiskAddOnFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoSnapshotAddOnRequest(combinedResult.T5, subFactoryAction));
}
