// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignStorageMinimumTimeToLiveFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive Create()
    {
        var storageMinimumTimeToLiveResult = CreateStorageMinimumTimeToLive();
        factoryAction?.Invoke(storageMinimumTimeToLiveResult);

        return storageMinimumTimeToLiveResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive CreateStorageMinimumTimeToLive()
    {
        var storageMinimumTimeToLiveResult = new Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive();

        return storageMinimumTimeToLiveResult;
    }

} // End Of Class

public static class InnerCampaignStorageMinimumTimeToLiveFactoryExtensions
{
}
