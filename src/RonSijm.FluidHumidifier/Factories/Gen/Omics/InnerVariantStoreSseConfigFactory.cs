// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerVariantStoreSseConfigFactory(Action<Humidifier.Omics.VariantStoreTypes.SseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Omics.VariantStoreTypes.SseConfig>
{

    protected override Humidifier.Omics.VariantStoreTypes.SseConfig Create()
    {
        var sseConfigResult = CreateSseConfig();
        factoryAction?.Invoke(sseConfigResult);

        return sseConfigResult;
    }

    private Humidifier.Omics.VariantStoreTypes.SseConfig CreateSseConfig()
    {
        var sseConfigResult = new Humidifier.Omics.VariantStoreTypes.SseConfig();

        return sseConfigResult;
    }

} // End Of Class

public static class InnerVariantStoreSseConfigFactoryExtensions
{
}
