// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Detective;

public class GraphFactory(string resourceName = null, Action<Humidifier.Detective.Graph> factoryAction = null) : ResourceFactory<Humidifier.Detective.Graph>(resourceName)
{

    protected override Humidifier.Detective.Graph Create()
    {
        var graphResult = CreateGraph();
        factoryAction?.Invoke(graphResult);

        return graphResult;
    }

    private Humidifier.Detective.Graph CreateGraph()
    {
        var graphResult = new Humidifier.Detective.Graph
        {
            GivenName = InputResourceName,
        };

        return graphResult;
    }

} // End Of Class

public static class GraphFactoryExtensions
{
}
