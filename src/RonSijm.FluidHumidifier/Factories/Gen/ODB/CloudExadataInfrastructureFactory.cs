// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class CloudExadataInfrastructureFactory(string resourceName = null, Action<Humidifier.ODB.CloudExadataInfrastructure> factoryAction = null) : ResourceFactory<Humidifier.ODB.CloudExadataInfrastructure>(resourceName)
{

    internal List<InnerCloudExadataInfrastructureCustomerContactFactory> CustomerContactsToSendToOCIFactories { get; set; } = [];

    internal InnerCloudExadataInfrastructureMaintenanceWindowFactory MaintenanceWindowFactory { get; set; }

    protected override Humidifier.ODB.CloudExadataInfrastructure Create()
    {
        var cloudExadataInfrastructureResult = CreateCloudExadataInfrastructure();
        factoryAction?.Invoke(cloudExadataInfrastructureResult);

        return cloudExadataInfrastructureResult;
    }

    private Humidifier.ODB.CloudExadataInfrastructure CreateCloudExadataInfrastructure()
    {
        var cloudExadataInfrastructureResult = new Humidifier.ODB.CloudExadataInfrastructure
        {
            GivenName = InputResourceName,
        };

        return cloudExadataInfrastructureResult;
    }
    public override void CreateChildren(Humidifier.ODB.CloudExadataInfrastructure result)
    {
        base.CreateChildren(result);

        result.CustomerContactsToSendToOCI = CustomerContactsToSendToOCIFactories.Any() ? CustomerContactsToSendToOCIFactories.Select(x => x.Build()).ToList() : null;
        result.MaintenanceWindow ??= MaintenanceWindowFactory?.Build();
    }

} // End Of Class

public static class CloudExadataInfrastructureFactoryExtensions
{
    public static CombinedResult<CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI(this CloudExadataInfrastructureFactory parentFactory, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null)
    {
        var factory = new InnerCloudExadataInfrastructureCustomerContactFactory(subFactoryAction);
        parentFactory.CustomerContactsToSendToOCIFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow(this CloudExadataInfrastructureFactory parentFactory, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null)
    {
        parentFactory.MaintenanceWindowFactory = new InnerCloudExadataInfrastructureMaintenanceWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceWindowFactory);
    }

    public static CombinedResult<CloudExadataInfrastructureFactory, T1, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1>(this CombinedResult<CloudExadataInfrastructureFactory, T1> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1>(this CombinedResult<T1, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, T4, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3, T4>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, T4, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3, T4>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, T4, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, T4, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureCustomerContactFactory> WithCustomerContactsToSendToOCI<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerContactsToSendToOCI(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<CloudExadataInfrastructureFactory, T1> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<T1, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, T4, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<CloudExadataInfrastructureFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, T4, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, CloudExadataInfrastructureFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, T4, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudExadataInfrastructureFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, T4, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudExadataInfrastructureFactory, T4> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudExadataInfrastructureFactory, InnerCloudExadataInfrastructureMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudExadataInfrastructureFactory> combinedResult, Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T5, subFactoryAction).T2);
}
