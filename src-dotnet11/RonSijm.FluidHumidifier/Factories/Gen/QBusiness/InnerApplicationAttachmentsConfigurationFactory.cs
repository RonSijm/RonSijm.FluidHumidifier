// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationAttachmentsConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration Create()
    {
        var attachmentsConfigurationResult = CreateAttachmentsConfiguration();
        factoryAction?.Invoke(attachmentsConfigurationResult);

        return attachmentsConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration CreateAttachmentsConfiguration()
    {
        var attachmentsConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration();

        return attachmentsConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationAttachmentsConfigurationFactoryExtensions
{
}
