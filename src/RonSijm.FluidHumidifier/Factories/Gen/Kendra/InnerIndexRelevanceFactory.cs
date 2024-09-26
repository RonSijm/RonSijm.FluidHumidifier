// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexRelevanceFactory(Action<Humidifier.Kendra.IndexTypes.Relevance> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.Relevance>
{

    protected override Humidifier.Kendra.IndexTypes.Relevance Create()
    {
        var relevanceResult = CreateRelevance();
        factoryAction?.Invoke(relevanceResult);

        return relevanceResult;
    }

    private Humidifier.Kendra.IndexTypes.Relevance CreateRelevance()
    {
        var relevanceResult = new Humidifier.Kendra.IndexTypes.Relevance();

        return relevanceResult;
    }

} // End Of Class

public static class InnerIndexRelevanceFactoryExtensions
{
}
