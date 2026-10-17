// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignAnswerMachineDetectionConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig Create()
    {
        var answerMachineDetectionConfigResult = CreateAnswerMachineDetectionConfig();
        factoryAction?.Invoke(answerMachineDetectionConfigResult);

        return answerMachineDetectionConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig CreateAnswerMachineDetectionConfig()
    {
        var answerMachineDetectionConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.AnswerMachineDetectionConfig();

        return answerMachineDetectionConfigResult;
    }

} // End Of Class

public static class InnerCampaignAnswerMachineDetectionConfigFactoryExtensions
{
}
