// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerSequenceStoreSseConfigFactory(Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Omics.SequenceStoreTypes.SseConfig>
{

    protected override Humidifier.Omics.SequenceStoreTypes.SseConfig Create()
    {
        var sseConfigResult = CreateSseConfig();
        factoryAction?.Invoke(sseConfigResult);

        return sseConfigResult;
    }

    private Humidifier.Omics.SequenceStoreTypes.SseConfig CreateSseConfig()
    {
        var sseConfigResult = new Humidifier.Omics.SequenceStoreTypes.SseConfig();

        return sseConfigResult;
    }

} // End Of Class

public static class InnerSequenceStoreSseConfigFactoryExtensions
{
}
