// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class GraphSnapshotFactory(string resourceName = null, Action<Humidifier.NeptuneGraph.GraphSnapshot> factoryAction = null) : ResourceFactory<Humidifier.NeptuneGraph.GraphSnapshot>(resourceName)
{

    protected override Humidifier.NeptuneGraph.GraphSnapshot Create()
    {
        var graphSnapshotResult = CreateGraphSnapshot();
        factoryAction?.Invoke(graphSnapshotResult);

        return graphSnapshotResult;
    }

    private Humidifier.NeptuneGraph.GraphSnapshot CreateGraphSnapshot()
    {
        var graphSnapshotResult = new Humidifier.NeptuneGraph.GraphSnapshot
        {
            GivenName = InputResourceName,
        };

        return graphSnapshotResult;
    }

} // End Of Class

public static class GraphSnapshotFactoryExtensions
{
}
