// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerFeaturedResultsSetFeaturedDocumentFactory(Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument>
{

    protected override Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument Create()
    {
        var featuredDocumentResult = CreateFeaturedDocument();
        factoryAction?.Invoke(featuredDocumentResult);

        return featuredDocumentResult;
    }

    private Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument CreateFeaturedDocument()
    {
        var featuredDocumentResult = new Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument();

        return featuredDocumentResult;
    }

} // End Of Class

public static class InnerFeaturedResultsSetFeaturedDocumentFactoryExtensions
{
}
