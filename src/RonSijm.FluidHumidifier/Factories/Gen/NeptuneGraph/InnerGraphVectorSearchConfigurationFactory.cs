// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class InnerGraphVectorSearchConfigurationFactory(Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration>
{

    protected override Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration Create()
    {
        var vectorSearchConfigurationResult = CreateVectorSearchConfiguration();
        factoryAction?.Invoke(vectorSearchConfigurationResult);

        return vectorSearchConfigurationResult;
    }

    private Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration CreateVectorSearchConfiguration()
    {
        var vectorSearchConfigurationResult = new Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration();

        return vectorSearchConfigurationResult;
    }

} // End Of Class

public static class InnerGraphVectorSearchConfigurationFactoryExtensions
{
}
