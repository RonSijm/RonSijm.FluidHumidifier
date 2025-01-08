// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateMessageTemplateBodyContentProviderFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider Create()
    {
        var messageTemplateBodyContentProviderResult = CreateMessageTemplateBodyContentProvider();
        factoryAction?.Invoke(messageTemplateBodyContentProviderResult);

        return messageTemplateBodyContentProviderResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider CreateMessageTemplateBodyContentProvider()
    {
        var messageTemplateBodyContentProviderResult = new Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider();

        return messageTemplateBodyContentProviderResult;
    }

} // End Of Class

public static class InnerMessageTemplateMessageTemplateBodyContentProviderFactoryExtensions
{
}
