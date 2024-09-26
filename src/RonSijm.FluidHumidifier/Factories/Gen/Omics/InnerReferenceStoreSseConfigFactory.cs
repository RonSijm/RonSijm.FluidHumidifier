// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerReferenceStoreSseConfigFactory(Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Omics.ReferenceStoreTypes.SseConfig>
{

    protected override Humidifier.Omics.ReferenceStoreTypes.SseConfig Create()
    {
        var sseConfigResult = CreateSseConfig();
        factoryAction?.Invoke(sseConfigResult);

        return sseConfigResult;
    }

    private Humidifier.Omics.ReferenceStoreTypes.SseConfig CreateSseConfig()
    {
        var sseConfigResult = new Humidifier.Omics.ReferenceStoreTypes.SseConfig();

        return sseConfigResult;
    }

} // End Of Class

public static class InnerReferenceStoreSseConfigFactoryExtensions
{
}
