// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignSignalInformationFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.SignalInformation> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.SignalInformation>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.SignalInformation Create()
    {
        var signalInformationResult = CreateSignalInformation();
        factoryAction?.Invoke(signalInformationResult);

        return signalInformationResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.SignalInformation CreateSignalInformation()
    {
        var signalInformationResult = new Humidifier.IoTFleetWise.CampaignTypes.SignalInformation();

        return signalInformationResult;
    }

} // End Of Class

public static class InnerCampaignSignalInformationFactoryExtensions
{
}
