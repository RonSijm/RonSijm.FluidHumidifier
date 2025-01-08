// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignStorageMaximumSizeFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize Create()
    {
        var storageMaximumSizeResult = CreateStorageMaximumSize();
        factoryAction?.Invoke(storageMaximumSizeResult);

        return storageMaximumSizeResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize CreateStorageMaximumSize()
    {
        var storageMaximumSizeResult = new Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize();

        return storageMaximumSizeResult;
    }

} // End Of Class

public static class InnerCampaignStorageMaximumSizeFactoryExtensions
{
}
