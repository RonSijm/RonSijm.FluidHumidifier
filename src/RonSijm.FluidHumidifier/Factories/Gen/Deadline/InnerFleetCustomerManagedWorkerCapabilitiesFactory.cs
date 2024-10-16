// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetCustomerManagedWorkerCapabilitiesFactory(Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities>
{

    internal InnerFleetAcceleratorCountRangeFactory AcceleratorCountFactory { get; set; }

    internal InnerFleetAcceleratorTotalMemoryMiBRangeFactory AcceleratorTotalMemoryMiBFactory { get; set; }

    internal InnerFleetVCpuCountRangeFactory VCpuCountFactory { get; set; }

    internal InnerFleetMemoryMiBRangeFactory MemoryMiBFactory { get; set; }

    protected override Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities Create()
    {
        var customerManagedWorkerCapabilitiesResult = CreateCustomerManagedWorkerCapabilities();
        factoryAction?.Invoke(customerManagedWorkerCapabilitiesResult);

        return customerManagedWorkerCapabilitiesResult;
    }

    private Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities CreateCustomerManagedWorkerCapabilities()
    {
        var customerManagedWorkerCapabilitiesResult = new Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities();

        return customerManagedWorkerCapabilitiesResult;
    }
    public override void CreateChildren(Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities result)
    {
        base.CreateChildren(result);

        result.AcceleratorCount ??= AcceleratorCountFactory?.Build();
        result.AcceleratorTotalMemoryMiB ??= AcceleratorTotalMemoryMiBFactory?.Build();
        result.VCpuCount ??= VCpuCountFactory?.Build();
        result.MemoryMiB ??= MemoryMiBFactory?.Build();
    }

} // End Of Class

public static class InnerFleetCustomerManagedWorkerCapabilitiesFactoryExtensions
{
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount(this InnerFleetCustomerManagedWorkerCapabilitiesFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null)
    {
        parentFactory.AcceleratorCountFactory = new InnerFleetAcceleratorCountRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AcceleratorCountFactory);
    }

    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB(this InnerFleetCustomerManagedWorkerCapabilitiesFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null)
    {
        parentFactory.AcceleratorTotalMemoryMiBFactory = new InnerFleetAcceleratorTotalMemoryMiBRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AcceleratorTotalMemoryMiBFactory);
    }

    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetVCpuCountRangeFactory> WithVCpuCount(this InnerFleetCustomerManagedWorkerCapabilitiesFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null)
    {
        parentFactory.VCpuCountFactory = new InnerFleetVCpuCountRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VCpuCountFactory);
    }

    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB(this InnerFleetCustomerManagedWorkerCapabilitiesFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null)
    {
        parentFactory.MemoryMiBFactory = new InnerFleetMemoryMiBRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemoryMiBFactory);
    }

    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3, T4>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithAcceleratorCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorCount(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3, T4>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetAcceleratorTotalMemoryMiBRangeFactory> WithAcceleratorTotalMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcceleratorTotalMemoryMiB(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithVCpuCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithVCpuCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3, T4>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetVCpuCountRangeFactory> WithVCpuCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVCpuCount(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3, T4>(this CombinedResult<InnerFleetCustomerManagedWorkerCapabilitiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory, InnerFleetMemoryMiBRangeFactory> WithMemoryMiB<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryMiB(combinedResult.T5, subFactoryAction));
}
