// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainNodeToNodeEncryptionOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions Create()
    {
        var nodeToNodeEncryptionOptionsResult = CreateNodeToNodeEncryptionOptions();
        factoryAction?.Invoke(nodeToNodeEncryptionOptionsResult);

        return nodeToNodeEncryptionOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions CreateNodeToNodeEncryptionOptions()
    {
        var nodeToNodeEncryptionOptionsResult = new Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions();

        return nodeToNodeEncryptionOptionsResult;
    }

} // End Of Class

public static class InnerDomainNodeToNodeEncryptionOptionsFactoryExtensions
{
}
