// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainNodeToNodeEncryptionOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions Create()
    {
        var nodeToNodeEncryptionOptionsResult = CreateNodeToNodeEncryptionOptions();
        factoryAction?.Invoke(nodeToNodeEncryptionOptionsResult);

        return nodeToNodeEncryptionOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions CreateNodeToNodeEncryptionOptions()
    {
        var nodeToNodeEncryptionOptionsResult = new Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions();

        return nodeToNodeEncryptionOptionsResult;
    }

} // End Of Class

public static class InnerDomainNodeToNodeEncryptionOptionsFactoryExtensions
{
}
