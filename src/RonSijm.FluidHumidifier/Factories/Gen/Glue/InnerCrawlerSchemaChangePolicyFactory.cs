// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCrawlerSchemaChangePolicyFactory(Action<Humidifier.Glue.CrawlerTypes.SchemaChangePolicy> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CrawlerTypes.SchemaChangePolicy>
{

    protected override Humidifier.Glue.CrawlerTypes.SchemaChangePolicy Create()
    {
        var schemaChangePolicyResult = CreateSchemaChangePolicy();
        factoryAction?.Invoke(schemaChangePolicyResult);

        return schemaChangePolicyResult;
    }

    private Humidifier.Glue.CrawlerTypes.SchemaChangePolicy CreateSchemaChangePolicy()
    {
        var schemaChangePolicyResult = new Humidifier.Glue.CrawlerTypes.SchemaChangePolicy();

        return schemaChangePolicyResult;
    }

} // End Of Class

public static class InnerCrawlerSchemaChangePolicyFactoryExtensions
{
}
