// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryRecordExpirySpecificationFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.RecordExpirySpecification> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.RecordExpirySpecification>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.RecordExpirySpecification Create()
    {
        var recordExpirySpecificationResult = CreateRecordExpirySpecification();
        factoryAction?.Invoke(recordExpirySpecificationResult);

        return recordExpirySpecificationResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.RecordExpirySpecification CreateRecordExpirySpecification()
    {
        var recordExpirySpecificationResult = new Humidifier.BedrockAgentCore.MemoryTypes.RecordExpirySpecification();

        return recordExpirySpecificationResult;
    }

} // End Of Class

public static class InnerMemoryRecordExpirySpecificationFactoryExtensions
{
}
