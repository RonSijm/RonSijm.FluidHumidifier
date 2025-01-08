// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignDataPartitionFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartition> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.DataPartition>
{

    internal InnerCampaignDataPartitionUploadOptionsFactory UploadOptionsFactory { get; set; }

    internal InnerCampaignDataPartitionStorageOptionsFactory StorageOptionsFactory { get; set; }

    protected override Humidifier.IoTFleetWise.CampaignTypes.DataPartition Create()
    {
        var dataPartitionResult = CreateDataPartition();
        factoryAction?.Invoke(dataPartitionResult);

        return dataPartitionResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.DataPartition CreateDataPartition()
    {
        var dataPartitionResult = new Humidifier.IoTFleetWise.CampaignTypes.DataPartition();

        return dataPartitionResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.CampaignTypes.DataPartition result)
    {
        base.CreateChildren(result);

        result.UploadOptions ??= UploadOptionsFactory?.Build();
        result.StorageOptions ??= StorageOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignDataPartitionFactoryExtensions
{
    public static CombinedResult<InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions(this InnerCampaignDataPartitionFactory parentFactory, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null)
    {
        parentFactory.UploadOptionsFactory = new InnerCampaignDataPartitionUploadOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UploadOptionsFactory);
    }

    public static CombinedResult<InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions(this InnerCampaignDataPartitionFactory parentFactory, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null)
    {
        parentFactory.StorageOptionsFactory = new InnerCampaignDataPartitionStorageOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageOptionsFactory);
    }

    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1>(this CombinedResult<InnerCampaignDataPartitionFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithUploadOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1>(this CombinedResult<T1, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithUploadOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, T4, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3, T4>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, T4, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, T4, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, T4, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionUploadOptionsFactory> WithUploadOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUploadOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1>(this CombinedResult<InnerCampaignDataPartitionFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1>(this CombinedResult<T1, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, T4, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3, T4>(this CombinedResult<InnerCampaignDataPartitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, T4, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignDataPartitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, T4, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignDataPartitionFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, T4, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignDataPartitionFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignDataPartitionFactory, InnerCampaignDataPartitionStorageOptionsFactory> WithStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignDataPartitionFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageOptions(combinedResult.T5, subFactoryAction));
}
