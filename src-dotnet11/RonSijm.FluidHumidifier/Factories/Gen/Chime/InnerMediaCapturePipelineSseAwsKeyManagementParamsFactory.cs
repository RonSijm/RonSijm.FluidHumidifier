// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineSseAwsKeyManagementParamsFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams Create()
    {
        var sseAwsKeyManagementParamsResult = CreateSseAwsKeyManagementParams();
        factoryAction?.Invoke(sseAwsKeyManagementParamsResult);

        return sseAwsKeyManagementParamsResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams CreateSseAwsKeyManagementParams()
    {
        var sseAwsKeyManagementParamsResult = new Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams();

        return sseAwsKeyManagementParamsResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineSseAwsKeyManagementParamsFactoryExtensions
{
}
