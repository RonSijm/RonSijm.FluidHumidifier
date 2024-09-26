// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class FleetFactory(string resourceName = null, Action<Humidifier.Deadline.Fleet> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Fleet>(resourceName)
{

    internal InnerFleetFleetConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Deadline.Fleet Create()
    {
        var fleetResult = CreateFleet();
        factoryAction?.Invoke(fleetResult);

        return fleetResult;
    }

    private Humidifier.Deadline.Fleet CreateFleet()
    {
        var fleetResult = new Humidifier.Deadline.Fleet
        {
            GivenName = InputResourceName,
        };

        return fleetResult;
    }
    public override void CreateChildren(Humidifier.Deadline.Fleet result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class FleetFactoryExtensions
{
    public static CombinedResult<FleetFactory, InnerFleetFleetConfigurationFactory> WithConfiguration(this FleetFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerFleetFleetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<FleetFactory, T1, InnerFleetFleetConfigurationFactory> WithConfiguration<T1>(this CombinedResult<FleetFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, InnerFleetFleetConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, FleetFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<FleetFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, FleetFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, FleetFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<FleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, FleetFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FleetFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetFactory, T1, T2, T3, T4, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<FleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetFactory, T2, T3, T4, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetFactory, T3, T4, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetFactory, T4, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetFactory, InnerFleetFleetConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.FleetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
