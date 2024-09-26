// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexProgramPipelineDetailFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail>
{

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail Create()
    {
        var multiplexProgramPipelineDetailResult = CreateMultiplexProgramPipelineDetail();
        factoryAction?.Invoke(multiplexProgramPipelineDetailResult);

        return multiplexProgramPipelineDetailResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail CreateMultiplexProgramPipelineDetail()
    {
        var multiplexProgramPipelineDetailResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail();

        return multiplexProgramPipelineDetailResult;
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexProgramPipelineDetailFactoryExtensions
{
}
