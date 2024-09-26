// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignTemplateFactory(Action<Humidifier.Pinpoint.CampaignTypes.Template> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.Template>
{

    protected override Humidifier.Pinpoint.CampaignTypes.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.Template CreateTemplate()
    {
        var templateResult = new Humidifier.Pinpoint.CampaignTypes.Template();

        return templateResult;
    }

} // End Of Class

public static class InnerCampaignTemplateFactoryExtensions
{
}
