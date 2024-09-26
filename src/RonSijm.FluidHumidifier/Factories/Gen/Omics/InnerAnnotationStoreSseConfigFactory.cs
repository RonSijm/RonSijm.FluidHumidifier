// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerAnnotationStoreSseConfigFactory(Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Omics.AnnotationStoreTypes.SseConfig>
{

    protected override Humidifier.Omics.AnnotationStoreTypes.SseConfig Create()
    {
        var sseConfigResult = CreateSseConfig();
        factoryAction?.Invoke(sseConfigResult);

        return sseConfigResult;
    }

    private Humidifier.Omics.AnnotationStoreTypes.SseConfig CreateSseConfig()
    {
        var sseConfigResult = new Humidifier.Omics.AnnotationStoreTypes.SseConfig();

        return sseConfigResult;
    }

} // End Of Class

public static class InnerAnnotationStoreSseConfigFactoryExtensions
{
}
