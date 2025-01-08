// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignDataPartitionUploadOptionsFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions Create()
    {
        var dataPartitionUploadOptionsResult = CreateDataPartitionUploadOptions();
        factoryAction?.Invoke(dataPartitionUploadOptionsResult);

        return dataPartitionUploadOptionsResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions CreateDataPartitionUploadOptions()
    {
        var dataPartitionUploadOptionsResult = new Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions();

        return dataPartitionUploadOptionsResult;
    }

} // End Of Class

public static class InnerCampaignDataPartitionUploadOptionsFactoryExtensions
{
}
