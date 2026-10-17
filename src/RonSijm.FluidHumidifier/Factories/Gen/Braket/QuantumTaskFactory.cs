// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class QuantumTaskFactory(string resourceName = null, Action<Humidifier.Braket.QuantumTask> factoryAction = null) : ResourceFactory<Humidifier.Braket.QuantumTask>(resourceName)
{

    internal List<InnerQuantumTaskAssociationFactory> AssociationsFactories { get; set; } = [];

    internal InnerQuantumTaskExperimentalCapabilitiesFactory ExperimentalCapabilitiesFactory { get; set; }

    protected override Humidifier.Braket.QuantumTask Create()
    {
        var quantumTaskResult = CreateQuantumTask();
        factoryAction?.Invoke(quantumTaskResult);

        return quantumTaskResult;
    }

    private Humidifier.Braket.QuantumTask CreateQuantumTask()
    {
        var quantumTaskResult = new Humidifier.Braket.QuantumTask
        {
            GivenName = InputResourceName,
        };

        return quantumTaskResult;
    }
    public override void CreateChildren(Humidifier.Braket.QuantumTask result)
    {
        base.CreateChildren(result);

        result.Associations = AssociationsFactories.Any() ? AssociationsFactories.Select(x => x.Build()).ToList() : null;
        result.ExperimentalCapabilities ??= ExperimentalCapabilitiesFactory?.Build();
    }

} // End Of Class

public static class QuantumTaskFactoryExtensions
{
    public static CombinedResult<QuantumTaskFactory, InnerQuantumTaskAssociationFactory> WithAssociations(this QuantumTaskFactory parentFactory, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null)
    {
        var factory = new InnerQuantumTaskAssociationFactory(subFactoryAction);
        parentFactory.AssociationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<QuantumTaskFactory, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities(this QuantumTaskFactory parentFactory, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null)
    {
        parentFactory.ExperimentalCapabilitiesFactory = new InnerQuantumTaskExperimentalCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExperimentalCapabilitiesFactory);
    }

    public static CombinedResult<QuantumTaskFactory, T1, InnerQuantumTaskAssociationFactory> WithAssociations<T1>(this CombinedResult<QuantumTaskFactory, T1> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, InnerQuantumTaskAssociationFactory> WithAssociations<T1>(this CombinedResult<T1, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2>(this CombinedResult<QuantumTaskFactory, T1, T2> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2>(this CombinedResult<T1, QuantumTaskFactory, T2> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2>(this CombinedResult<T1, T2, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, T3, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3>(this CombinedResult<QuantumTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, T3, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3>(this CombinedResult<T1, QuantumTaskFactory, T2, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, T3, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3>(this CombinedResult<T1, T2, QuantumTaskFactory, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuantumTaskFactory, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, T3, T4, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3, T4>(this CombinedResult<QuantumTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, T3, T4, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3, T4>(this CombinedResult<T1, QuantumTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, T3, T4, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuantumTaskFactory, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuantumTaskFactory, T4, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuantumTaskFactory, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QuantumTaskFactory, InnerQuantumTaskAssociationFactory> WithAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.Association> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1>(this CombinedResult<QuantumTaskFactory, T1> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1>(this CombinedResult<T1, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2>(this CombinedResult<QuantumTaskFactory, T1, T2> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2>(this CombinedResult<T1, QuantumTaskFactory, T2> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2>(this CombinedResult<T1, T2, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, T3, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3>(this CombinedResult<QuantumTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, T3, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3>(this CombinedResult<T1, QuantumTaskFactory, T2, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, T3, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, QuantumTaskFactory, T3> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuantumTaskFactory, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QuantumTaskFactory, T1, T2, T3, T4, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3, T4>(this CombinedResult<QuantumTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuantumTaskFactory, T2, T3, T4, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, QuantumTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuantumTaskFactory, T3, T4, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuantumTaskFactory, T3, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuantumTaskFactory, T4, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuantumTaskFactory, T4> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QuantumTaskFactory, InnerQuantumTaskExperimentalCapabilitiesFactory> WithExperimentalCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuantumTaskFactory> combinedResult, Action<Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentalCapabilities(combinedResult.T5, subFactoryAction).T2);
}
