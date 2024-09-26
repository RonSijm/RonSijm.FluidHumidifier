// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDocumentClassifierDocumentClassifierOutputDataConfigFactory(Action<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig>
{

    protected override Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig Create()
    {
        var documentClassifierOutputDataConfigResult = CreateDocumentClassifierOutputDataConfig();
        factoryAction?.Invoke(documentClassifierOutputDataConfigResult);

        return documentClassifierOutputDataConfigResult;
    }

    private Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig CreateDocumentClassifierOutputDataConfig()
    {
        var documentClassifierOutputDataConfigResult = new Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig();

        return documentClassifierOutputDataConfigResult;
    }

} // End Of Class

public static class InnerDocumentClassifierDocumentClassifierOutputDataConfigFactoryExtensions
{
}
