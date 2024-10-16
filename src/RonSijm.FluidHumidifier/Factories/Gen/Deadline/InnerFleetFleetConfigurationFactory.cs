// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetFleetConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.FleetConfiguration>
{

    internal InnerFleetServiceManagedEc2FleetConfigurationFactory ServiceManagedEc2Factory { get; set; }

    internal InnerFleetCustomerManagedFleetConfigurationFactory CustomerManagedFactory { get; set; }

    protected override Humidifier.Deadline.FleetTypes.FleetConfiguration Create()
    {
        var fleetConfigurationResult = CreateFleetConfiguration();
        factoryAction?.Invoke(fleetConfigurationResult);

        return fleetConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.FleetConfiguration CreateFleetConfiguration()
    {
        var fleetConfigurationResult = new Humidifier.Deadline.FleetTypes.FleetConfiguration();

        return fleetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Deadline.FleetTypes.FleetConfiguration result)
    {
        base.CreateChildren(result);

        result.ServiceManagedEc2 ??= ServiceManagedEc2Factory?.Build();
        result.CustomerManaged ??= CustomerManagedFactory?.Build();
    }

} // End Of Class

public static class InnerFleetFleetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFleetFleetConfigurationFactory, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2(this InnerFleetFleetConfigurationFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null)
    {
        parentFactory.ServiceManagedEc2Factory = new InnerFleetServiceManagedEc2FleetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceManagedEc2Factory);
    }

    public static CombinedResult<InnerFleetFleetConfigurationFactory, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged(this InnerFleetFleetConfigurationFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomerManagedFactory = new InnerFleetCustomerManagedFleetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomerManagedFactory);
    }

    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, T4, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3, T4>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, T4, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, T4, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, T4, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetFleetConfigurationFactory, InnerFleetServiceManagedEc2FleetConfigurationFactory> WithServiceManagedEc2<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManagedEc2(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManaged(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManaged(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, T4, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3, T4>(this CombinedResult<InnerFleetFleetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, T4, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetFleetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, T4, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetFleetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, T4, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetFleetConfigurationFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetFleetConfigurationFactory, InnerFleetCustomerManagedFleetConfigurationFactory> WithCustomerManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetFleetConfigurationFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManaged(combinedResult.T5, subFactoryAction));
}
