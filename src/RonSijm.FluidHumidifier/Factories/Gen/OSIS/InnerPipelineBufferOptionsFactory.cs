// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineBufferOptionsFactory(Action<Humidifier.OSIS.PipelineTypes.BufferOptions> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.BufferOptions>
{

    protected override Humidifier.OSIS.PipelineTypes.BufferOptions Create()
    {
        var bufferOptionsResult = CreateBufferOptions();
        factoryAction?.Invoke(bufferOptionsResult);

        return bufferOptionsResult;
    }

    private Humidifier.OSIS.PipelineTypes.BufferOptions CreateBufferOptions()
    {
        var bufferOptionsResult = new Humidifier.OSIS.PipelineTypes.BufferOptions();

        return bufferOptionsResult;
    }

} // End Of Class

public static class InnerPipelineBufferOptionsFactoryExtensions
{
}
