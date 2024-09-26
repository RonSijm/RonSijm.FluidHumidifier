// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SimSpaceWeaver;

public class SimulationFactory(string resourceName = null, Action<Humidifier.SimSpaceWeaver.Simulation> factoryAction = null) : ResourceFactory<Humidifier.SimSpaceWeaver.Simulation>(resourceName)
{

    internal InnerSimulationS3LocationFactory SchemaS3LocationFactory { get; set; }

    internal InnerSimulationS3LocationFactory SnapshotS3LocationFactory { get; set; }

    protected override Humidifier.SimSpaceWeaver.Simulation Create()
    {
        var simulationResult = CreateSimulation();
        factoryAction?.Invoke(simulationResult);

        return simulationResult;
    }

    private Humidifier.SimSpaceWeaver.Simulation CreateSimulation()
    {
        var simulationResult = new Humidifier.SimSpaceWeaver.Simulation
        {
            GivenName = InputResourceName,
        };

        return simulationResult;
    }
    public override void CreateChildren(Humidifier.SimSpaceWeaver.Simulation result)
    {
        base.CreateChildren(result);

        result.SchemaS3Location ??= SchemaS3LocationFactory?.Build();
        result.SnapshotS3Location ??= SnapshotS3LocationFactory?.Build();
    }

} // End Of Class

public static class SimulationFactoryExtensions
{
    public static CombinedResult<SimulationFactory, InnerSimulationS3LocationFactory> WithSchemaS3Location(this SimulationFactory parentFactory, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.SchemaS3LocationFactory = new InnerSimulationS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaS3LocationFactory);
    }

    public static CombinedResult<SimulationFactory, InnerSimulationS3LocationFactory> WithSnapshotS3Location(this SimulationFactory parentFactory, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.SnapshotS3LocationFactory = new InnerSimulationS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SnapshotS3LocationFactory);
    }

    public static CombinedResult<SimulationFactory, T1, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1>(this CombinedResult<SimulationFactory, T1> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1>(this CombinedResult<T1, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2>(this CombinedResult<SimulationFactory, T1, T2> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2>(this CombinedResult<T1, SimulationFactory, T2> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2>(this CombinedResult<T1, T2, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, T3, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3>(this CombinedResult<SimulationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, T3, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3>(this CombinedResult<T1, SimulationFactory, T2, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, T3, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3>(this CombinedResult<T1, T2, SimulationFactory, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimulationFactory, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, T3, T4, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3, T4>(this CombinedResult<SimulationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, T3, T4, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3, T4>(this CombinedResult<T1, SimulationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, T3, T4, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, SimulationFactory, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimulationFactory, T4, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SimulationFactory, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SimulationFactory, InnerSimulationS3LocationFactory> WithSchemaS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaS3Location(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1>(this CombinedResult<SimulationFactory, T1> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1>(this CombinedResult<T1, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2>(this CombinedResult<SimulationFactory, T1, T2> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2>(this CombinedResult<T1, SimulationFactory, T2> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2>(this CombinedResult<T1, T2, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, T3, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3>(this CombinedResult<SimulationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, T3, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3>(this CombinedResult<T1, SimulationFactory, T2, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, T3, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3>(this CombinedResult<T1, T2, SimulationFactory, T3> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimulationFactory, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SimulationFactory, T1, T2, T3, T4, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3, T4>(this CombinedResult<SimulationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimulationFactory, T2, T3, T4, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3, T4>(this CombinedResult<T1, SimulationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimulationFactory, T3, T4, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, SimulationFactory, T3, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimulationFactory, T4, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SimulationFactory, T4> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SimulationFactory, InnerSimulationS3LocationFactory> WithSnapshotS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SimulationFactory> combinedResult, Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotS3Location(combinedResult.T5, subFactoryAction));
}
