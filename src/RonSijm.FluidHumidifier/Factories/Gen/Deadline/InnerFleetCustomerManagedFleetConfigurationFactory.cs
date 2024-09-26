// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetCustomerManagedFleetConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration>
{

    internal InnerFleetCustomerManagedWorkerCapabilitiesFactory WorkerCapabilitiesFactory { get; set; }

    protected override Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration Create()
    {
        var customerManagedFleetConfigurationResult = CreateCustomerManagedFleetConfiguration();
        factoryAction?.Invoke(customerManagedFleetConfigurationResult);

        return customerManagedFleetConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration CreateCustomerManagedFleetConfiguration()
    {
        var customerManagedFleetConfigurationResult = new Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration();

        return customerManagedFleetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration result)
    {
        base.CreateChildren(result);

        result.WorkerCapabilities ??= WorkerCapabilitiesFactory?.Build();
    }

} // End Of Class

public static class InnerFleetCustomerManagedFleetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities(this InnerFleetCustomerManagedFleetConfigurationFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null)
    {
        parentFactory.WorkerCapabilitiesFactory = new InnerFleetCustomerManagedWorkerCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkerCapabilitiesFactory);
    }

    public static CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1>(this CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1>(this CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2>(this CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2>(this CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2>(this CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3>(this CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3>(this CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory, T3, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3, T4>(this CombinedResult<InnerFleetCustomerManagedFleetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetCustomerManagedFleetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory, T3, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory, T4, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedFleetConfigurationFactory, InnerFleetCustomerManagedWorkerCapabilitiesFactory> WithWorkerCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetCustomerManagedFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerCapabilities(combinedResult.T5, subFactoryAction));
}
