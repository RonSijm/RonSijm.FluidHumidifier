// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudExadataInfrastructureCustomerContactFactory(Action<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact>
{

    protected override Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact Create()
    {
        var customerContactResult = CreateCustomerContact();
        factoryAction?.Invoke(customerContactResult);

        return customerContactResult;
    }

    private Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact CreateCustomerContact()
    {
        var customerContactResult = new Humidifier.ODB.CloudExadataInfrastructureTypes.CustomerContact();

        return customerContactResult;
    }

} // End Of Class

public static class InnerCloudExadataInfrastructureCustomerContactFactoryExtensions
{
}
