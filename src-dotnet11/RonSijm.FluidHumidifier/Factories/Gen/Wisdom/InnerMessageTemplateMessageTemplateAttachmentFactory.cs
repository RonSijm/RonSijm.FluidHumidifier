// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateMessageTemplateAttachmentFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment Create()
    {
        var messageTemplateAttachmentResult = CreateMessageTemplateAttachment();
        factoryAction?.Invoke(messageTemplateAttachmentResult);

        return messageTemplateAttachmentResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment CreateMessageTemplateAttachment()
    {
        var messageTemplateAttachmentResult = new Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment();

        return messageTemplateAttachmentResult;
    }

} // End Of Class

public static class InnerMessageTemplateMessageTemplateAttachmentFactoryExtensions
{
}
