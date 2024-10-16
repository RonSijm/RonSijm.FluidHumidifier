// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainEncryptionAtRestOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions Create()
    {
        var encryptionAtRestOptionsResult = CreateEncryptionAtRestOptions();
        factoryAction?.Invoke(encryptionAtRestOptionsResult);

        return encryptionAtRestOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions CreateEncryptionAtRestOptions()
    {
        var encryptionAtRestOptionsResult = new Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions();

        return encryptionAtRestOptionsResult;
    }

} // End Of Class

public static class InnerDomainEncryptionAtRestOptionsFactoryExtensions
{
}
