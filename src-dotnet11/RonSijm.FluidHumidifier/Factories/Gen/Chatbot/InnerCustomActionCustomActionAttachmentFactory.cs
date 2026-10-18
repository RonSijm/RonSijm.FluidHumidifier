// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chatbot;

public class InnerCustomActionCustomActionAttachmentFactory(Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> factoryAction = null) : SubResourceFactory<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment>
{

    protected override Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment Create()
    {
        var customActionAttachmentResult = CreateCustomActionAttachment();
        factoryAction?.Invoke(customActionAttachmentResult);

        return customActionAttachmentResult;
    }

    private Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment CreateCustomActionAttachment()
    {
        var customActionAttachmentResult = new Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment();

        return customActionAttachmentResult;
    }

} // End Of Class

public static class InnerCustomActionCustomActionAttachmentFactoryExtensions
{
}
