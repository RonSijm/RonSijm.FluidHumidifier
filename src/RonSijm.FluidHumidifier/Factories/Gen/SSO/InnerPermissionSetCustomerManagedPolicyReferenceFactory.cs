// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerPermissionSetCustomerManagedPolicyReferenceFactory(Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> factoryAction = null) : SubResourceFactory<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference>
{

    protected override Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference Create()
    {
        var customerManagedPolicyReferenceResult = CreateCustomerManagedPolicyReference();
        factoryAction?.Invoke(customerManagedPolicyReferenceResult);

        return customerManagedPolicyReferenceResult;
    }

    private Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference CreateCustomerManagedPolicyReference()
    {
        var customerManagedPolicyReferenceResult = new Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference();

        return customerManagedPolicyReferenceResult;
    }

} // End Of Class

public static class InnerPermissionSetCustomerManagedPolicyReferenceFactoryExtensions
{
}
