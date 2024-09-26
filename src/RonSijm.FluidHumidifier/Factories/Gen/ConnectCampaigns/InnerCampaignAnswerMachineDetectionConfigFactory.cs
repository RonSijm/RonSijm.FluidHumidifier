// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class InnerCampaignAnswerMachineDetectionConfigFactory(Action<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig>
{

    protected override Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig Create()
    {
        var answerMachineDetectionConfigResult = CreateAnswerMachineDetectionConfig();
        factoryAction?.Invoke(answerMachineDetectionConfigResult);

        return answerMachineDetectionConfigResult;
    }

    private Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig CreateAnswerMachineDetectionConfig()
    {
        var answerMachineDetectionConfigResult = new Humidifier.ConnectCampaigns.CampaignTypes.AnswerMachineDetectionConfig();

        return answerMachineDetectionConfigResult;
    }

} // End Of Class

public static class InnerCampaignAnswerMachineDetectionConfigFactoryExtensions
{
}
