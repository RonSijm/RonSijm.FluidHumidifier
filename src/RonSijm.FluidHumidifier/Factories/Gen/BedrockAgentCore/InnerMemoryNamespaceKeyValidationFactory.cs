// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryNamespaceKeyValidationFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation Create()
    {
        var namespaceKeyValidationResult = CreateNamespaceKeyValidation();
        factoryAction?.Invoke(namespaceKeyValidationResult);

        return namespaceKeyValidationResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation CreateNamespaceKeyValidation()
    {
        var namespaceKeyValidationResult = new Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation();

        return namespaceKeyValidationResult;
    }

} // End Of Class

public static class InnerMemoryNamespaceKeyValidationFactoryExtensions
{
}
