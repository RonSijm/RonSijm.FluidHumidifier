// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerPermissionSetPermissionsBoundaryFactory(Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> factoryAction = null) : SubResourceFactory<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary>
{

    internal InnerPermissionSetCustomerManagedPolicyReferenceFactory CustomerManagedPolicyReferenceFactory { get; set; }

    protected override Humidifier.SSO.PermissionSetTypes.PermissionsBoundary Create()
    {
        var permissionsBoundaryResult = CreatePermissionsBoundary();
        factoryAction?.Invoke(permissionsBoundaryResult);

        return permissionsBoundaryResult;
    }

    private Humidifier.SSO.PermissionSetTypes.PermissionsBoundary CreatePermissionsBoundary()
    {
        var permissionsBoundaryResult = new Humidifier.SSO.PermissionSetTypes.PermissionsBoundary();

        return permissionsBoundaryResult;
    }
    public override void CreateChildren(Humidifier.SSO.PermissionSetTypes.PermissionsBoundary result)
    {
        base.CreateChildren(result);

        result.CustomerManagedPolicyReference ??= CustomerManagedPolicyReferenceFactory?.Build();
    }

} // End Of Class

public static class InnerPermissionSetPermissionsBoundaryFactoryExtensions
{
    public static CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference(this InnerPermissionSetPermissionsBoundaryFactory parentFactory, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null)
    {
        parentFactory.CustomerManagedPolicyReferenceFactory = new InnerPermissionSetCustomerManagedPolicyReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomerManagedPolicyReferenceFactory);
    }

    public static CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1>(this CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1>(this CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2>(this CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2>(this CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2>(this CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3>(this CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3>(this CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionSetPermissionsBoundaryFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPermissionSetPermissionsBoundaryFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3, T4>(this CombinedResult<InnerPermissionSetPermissionsBoundaryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerPermissionSetPermissionsBoundaryFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPermissionSetPermissionsBoundaryFactory, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPermissionSetPermissionsBoundaryFactory, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPermissionSetPermissionsBoundaryFactory, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPermissionSetPermissionsBoundaryFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPermissionSetPermissionsBoundaryFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReference(combinedResult.T5, subFactoryAction));
}
