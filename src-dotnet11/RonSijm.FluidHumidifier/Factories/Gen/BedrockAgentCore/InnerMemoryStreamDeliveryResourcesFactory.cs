// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryStreamDeliveryResourcesFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources Create()
    {
        var streamDeliveryResourcesResult = CreateStreamDeliveryResources();
        factoryAction?.Invoke(streamDeliveryResourcesResult);

        return streamDeliveryResourcesResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources CreateStreamDeliveryResources()
    {
        var streamDeliveryResourcesResult = new Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources();

        return streamDeliveryResourcesResult;
    }

} // End Of Class

public static class InnerMemoryStreamDeliveryResourcesFactoryExtensions
{
}
