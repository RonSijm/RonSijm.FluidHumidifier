// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class DiskFactory(string resourceName = null, Action<Humidifier.Lightsail.Disk> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Disk>(resourceName)
{

    internal List<InnerDiskAddOnFactory> AddOnsFactories { get; set; } = [];

    internal InnerDiskLocationFactory LocationFactory { get; set; }

    protected override Humidifier.Lightsail.Disk Create()
    {
        var diskResult = CreateDisk();
        factoryAction?.Invoke(diskResult);

        return diskResult;
    }

    private Humidifier.Lightsail.Disk CreateDisk()
    {
        var diskResult = new Humidifier.Lightsail.Disk
        {
            GivenName = InputResourceName,
        };

        return diskResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Disk result)
    {
        base.CreateChildren(result);

        result.AddOns = AddOnsFactories.Any() ? AddOnsFactories.Select(x => x.Build()).ToList() : null;
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class DiskFactoryExtensions
{
    public static CombinedResult<DiskFactory, InnerDiskAddOnFactory> WithAddOns(this DiskFactory parentFactory, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null)
    {
        var factory = new InnerDiskAddOnFactory(subFactoryAction);
        parentFactory.AddOnsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DiskFactory, InnerDiskLocationFactory> WithLocation(this DiskFactory parentFactory, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerDiskLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<DiskFactory, T1, InnerDiskAddOnFactory> WithAddOns<T1>(this CombinedResult<DiskFactory, T1> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, InnerDiskAddOnFactory> WithAddOns<T1>(this CombinedResult<T1, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, InnerDiskAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<DiskFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, InnerDiskAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<T1, DiskFactory, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, InnerDiskAddOnFactory> WithAddOns<T1, T2>(this CombinedResult<T1, T2, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, T3, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<DiskFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, T3, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, DiskFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, T3, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, T2, DiskFactory, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiskFactory, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3>(this CombinedResult<T1, T2, T3, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, T3, T4, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<DiskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, T3, T4, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, DiskFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, T3, T4, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, DiskFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiskFactory, T4, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DiskFactory, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DiskFactory, InnerDiskAddOnFactory> WithAddOns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.AddOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddOns(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, InnerDiskLocationFactory> WithLocation<T1>(this CombinedResult<DiskFactory, T1> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, InnerDiskLocationFactory> WithLocation<T1>(this CombinedResult<T1, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, InnerDiskLocationFactory> WithLocation<T1, T2>(this CombinedResult<DiskFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, InnerDiskLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, DiskFactory, T2> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, InnerDiskLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, T3, InnerDiskLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<DiskFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, T3, InnerDiskLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, DiskFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, T3, InnerDiskLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, DiskFactory, T3> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiskFactory, InnerDiskLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DiskFactory, T1, T2, T3, T4, InnerDiskLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<DiskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiskFactory, T2, T3, T4, InnerDiskLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, DiskFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiskFactory, T3, T4, InnerDiskLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, DiskFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiskFactory, T4, InnerDiskLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DiskFactory, T4> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DiskFactory, InnerDiskLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DiskFactory> combinedResult, Action<Humidifier.Lightsail.DiskTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
