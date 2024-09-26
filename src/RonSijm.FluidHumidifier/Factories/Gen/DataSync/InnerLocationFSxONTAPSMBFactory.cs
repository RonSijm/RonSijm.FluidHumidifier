// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxONTAPSMBFactory(Action<Humidifier.DataSync.LocationFSxONTAPTypes.SMB> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxONTAPTypes.SMB>
{

    internal InnerLocationFSxONTAPSmbMountOptionsFactory MountOptionsFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxONTAPTypes.SMB Create()
    {
        var sMBResult = CreateSMB();
        factoryAction?.Invoke(sMBResult);

        return sMBResult;
    }

    private Humidifier.DataSync.LocationFSxONTAPTypes.SMB CreateSMB()
    {
        var sMBResult = new Humidifier.DataSync.LocationFSxONTAPTypes.SMB();

        return sMBResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxONTAPTypes.SMB result)
    {
        base.CreateChildren(result);

        result.MountOptions ??= MountOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerLocationFSxONTAPSMBFactoryExtensions
{
    public static CombinedResult<InnerLocationFSxONTAPSMBFactory, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions(this InnerLocationFSxONTAPSMBFactory parentFactory, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationFSxONTAPSmbMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<InnerLocationFSxONTAPSMBFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, InnerLocationFSxONTAPSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2, T3, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2, T3, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory, T3, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPSMBFactory, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2, T3, T4, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<InnerLocationFSxONTAPSMBFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2, T3, T4, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationFSxONTAPSMBFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory, T3, T4, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationFSxONTAPSMBFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLocationFSxONTAPSMBFactory, T4, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationFSxONTAPSMBFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPSMBFactory, InnerLocationFSxONTAPSmbMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationFSxONTAPSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction));
}
