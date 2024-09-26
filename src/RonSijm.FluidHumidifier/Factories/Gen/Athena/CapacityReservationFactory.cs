// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class CapacityReservationFactory(string resourceName = null, Action<Humidifier.Athena.CapacityReservation> factoryAction = null) : ResourceFactory<Humidifier.Athena.CapacityReservation>(resourceName)
{

    internal InnerCapacityReservationCapacityAssignmentConfigurationFactory CapacityAssignmentConfigurationFactory { get; set; }

    protected override Humidifier.Athena.CapacityReservation Create()
    {
        var capacityReservationResult = CreateCapacityReservation();
        factoryAction?.Invoke(capacityReservationResult);

        return capacityReservationResult;
    }

    private Humidifier.Athena.CapacityReservation CreateCapacityReservation()
    {
        var capacityReservationResult = new Humidifier.Athena.CapacityReservation
        {
            GivenName = InputResourceName,
        };

        return capacityReservationResult;
    }
    public override void CreateChildren(Humidifier.Athena.CapacityReservation result)
    {
        base.CreateChildren(result);

        result.CapacityAssignmentConfiguration ??= CapacityAssignmentConfigurationFactory?.Build();
    }

} // End Of Class

public static class CapacityReservationFactoryExtensions
{
    public static CombinedResult<CapacityReservationFactory, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration(this CapacityReservationFactory parentFactory, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null)
    {
        parentFactory.CapacityAssignmentConfigurationFactory = new InnerCapacityReservationCapacityAssignmentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityAssignmentConfigurationFactory);
    }

    public static CombinedResult<CapacityReservationFactory, T1, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1>(this CombinedResult<CapacityReservationFactory, T1> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1>(this CombinedResult<T1, CapacityReservationFactory> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2>(this CombinedResult<CapacityReservationFactory, T1, T2> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2>(this CombinedResult<T1, CapacityReservationFactory, T2> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2>(this CombinedResult<T1, T2, CapacityReservationFactory> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, T3, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3>(this CombinedResult<CapacityReservationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, T3, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3>(this CombinedResult<T1, CapacityReservationFactory, T2, T3> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, T3, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CapacityReservationFactory, T3> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFactory, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityReservationFactory> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, T3, T4, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3, T4>(this CombinedResult<CapacityReservationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, T3, T4, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CapacityReservationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, T3, T4, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityReservationFactory, T3, T4> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFactory, T4, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityReservationFactory, T4> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapacityReservationFactory, InnerCapacityReservationCapacityAssignmentConfigurationFactory> WithCapacityAssignmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityReservationFactory> combinedResult, Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityAssignmentConfiguration(combinedResult.T5, subFactoryAction));
}
