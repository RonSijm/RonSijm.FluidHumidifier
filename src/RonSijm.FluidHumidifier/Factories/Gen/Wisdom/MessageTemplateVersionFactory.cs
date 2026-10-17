// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class MessageTemplateVersionFactory(string resourceName = null, Action<Humidifier.Wisdom.MessageTemplateVersion> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.MessageTemplateVersion>(resourceName)
{

    protected override Humidifier.Wisdom.MessageTemplateVersion Create()
    {
        var messageTemplateVersionResult = CreateMessageTemplateVersion();
        factoryAction?.Invoke(messageTemplateVersionResult);

        return messageTemplateVersionResult;
    }

    private Humidifier.Wisdom.MessageTemplateVersion CreateMessageTemplateVersion()
    {
        var messageTemplateVersionResult = new Humidifier.Wisdom.MessageTemplateVersion
        {
            GivenName = InputResourceName,
        };

        return messageTemplateVersionResult;
    }

} // End Of Class

public static class MessageTemplateVersionFactoryExtensions
{
}
