// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class PermissionSetFactory(string resourceName = null, Action<Humidifier.SSO.PermissionSet> factoryAction = null) : ResourceFactory<Humidifier.SSO.PermissionSet>(resourceName)
{

    internal List<InnerPermissionSetCustomerManagedPolicyReferenceFactory> CustomerManagedPolicyReferencesFactories { get; set; } = [];

    internal InnerPermissionSetPermissionsBoundaryFactory PermissionsBoundaryFactory { get; set; }

    protected override Humidifier.SSO.PermissionSet Create()
    {
        var permissionSetResult = CreatePermissionSet();
        factoryAction?.Invoke(permissionSetResult);

        return permissionSetResult;
    }

    private Humidifier.SSO.PermissionSet CreatePermissionSet()
    {
        var permissionSetResult = new Humidifier.SSO.PermissionSet
        {
            GivenName = InputResourceName,
        };

        return permissionSetResult;
    }
    public override void CreateChildren(Humidifier.SSO.PermissionSet result)
    {
        base.CreateChildren(result);

        result.CustomerManagedPolicyReferences = CustomerManagedPolicyReferencesFactories.Any() ? CustomerManagedPolicyReferencesFactories.Select(x => x.Build()).ToList() : null;
        result.PermissionsBoundary ??= PermissionsBoundaryFactory?.Build();
    }

} // End Of Class

public static class PermissionSetFactoryExtensions
{
    public static CombinedResult<PermissionSetFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences(this PermissionSetFactory parentFactory, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null)
    {
        var factory = new InnerPermissionSetCustomerManagedPolicyReferenceFactory(subFactoryAction);
        parentFactory.CustomerManagedPolicyReferencesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PermissionSetFactory, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary(this PermissionSetFactory parentFactory, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null)
    {
        parentFactory.PermissionsBoundaryFactory = new InnerPermissionSetPermissionsBoundaryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PermissionsBoundaryFactory);
    }

    public static CombinedResult<PermissionSetFactory, T1, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1>(this CombinedResult<PermissionSetFactory, T1> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1>(this CombinedResult<T1, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2>(this CombinedResult<PermissionSetFactory, T1, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2>(this CombinedResult<T1, PermissionSetFactory, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2>(this CombinedResult<T1, T2, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3>(this CombinedResult<PermissionSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3>(this CombinedResult<T1, PermissionSetFactory, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, T3, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3>(this CombinedResult<T1, T2, PermissionSetFactory, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionSetFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3>(this CombinedResult<T1, T2, T3, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3, T4>(this CombinedResult<PermissionSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3, T4>(this CombinedResult<T1, PermissionSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, T3, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, PermissionSetFactory, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionSetFactory, T4, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PermissionSetFactory, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PermissionSetFactory, InnerPermissionSetCustomerManagedPolicyReferenceFactory> WithCustomerManagedPolicyReferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedPolicyReferences(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1>(this CombinedResult<PermissionSetFactory, T1> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1>(this CombinedResult<T1, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2>(this CombinedResult<PermissionSetFactory, T1, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2>(this CombinedResult<T1, PermissionSetFactory, T2> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2>(this CombinedResult<T1, T2, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, T3, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3>(this CombinedResult<PermissionSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, T3, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3>(this CombinedResult<T1, PermissionSetFactory, T2, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, T3, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3>(this CombinedResult<T1, T2, PermissionSetFactory, T3> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionSetFactory, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3>(this CombinedResult<T1, T2, T3, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PermissionSetFactory, T1, T2, T3, T4, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3, T4>(this CombinedResult<PermissionSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PermissionSetFactory, T2, T3, T4, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3, T4>(this CombinedResult<T1, PermissionSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PermissionSetFactory, T3, T4, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3, T4>(this CombinedResult<T1, T2, PermissionSetFactory, T3, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PermissionSetFactory, T4, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PermissionSetFactory, T4> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PermissionSetFactory, InnerPermissionSetPermissionsBoundaryFactory> WithPermissionsBoundary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PermissionSetFactory> combinedResult, Action<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsBoundary(combinedResult.T5, subFactoryAction));
}
