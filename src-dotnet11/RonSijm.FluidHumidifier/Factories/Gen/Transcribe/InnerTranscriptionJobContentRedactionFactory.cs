// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerTranscriptionJobContentRedactionFactory(Action<Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction>
{

    protected override Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction Create()
    {
        var contentRedactionResult = CreateContentRedaction();
        factoryAction?.Invoke(contentRedactionResult);

        return contentRedactionResult;
    }

    private Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction CreateContentRedaction()
    {
        var contentRedactionResult = new Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction();

        return contentRedactionResult;
    }

} // End Of Class

public static class InnerTranscriptionJobContentRedactionFactoryExtensions
{
}
