// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainS3VectorsEngineFactory(Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine>
{

    protected override Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine Create()
    {
        var s3VectorsEngineResult = CreateS3VectorsEngine();
        factoryAction?.Invoke(s3VectorsEngineResult);

        return s3VectorsEngineResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine CreateS3VectorsEngine()
    {
        var s3VectorsEngineResult = new Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine();

        return s3VectorsEngineResult;
    }

} // End Of Class

public static class InnerDomainS3VectorsEngineFactoryExtensions
{
}
