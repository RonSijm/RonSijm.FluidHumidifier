// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class PermissionFactory(string resourceName = null, Action<Humidifier.QBusiness.Permission> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.Permission>(resourceName)
{

    internal List<InnerPermissionConditionFactory> ConditionsFactories { get; set; } = [];

    protected override Humidifier.QBusiness.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.QBusiness.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.QBusiness.Permission
        {
            GivenName = InputResourceName,
        };

        return permissionResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.Permission result)
    {
        base.CreateChildren(result);

        result.Conditions = ConditionsFactories.Any() ? ConditionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PermissionFactoryExtensions
{
    public static CombinedResult<PermissionFactory, InnerPermissionConditionFactory> WithConditions(this PermissionFactory parentFactory, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null)
    {
        var factory = new InnerPermissionConditionFactory(subFactoryAction);
        parentFactory.ConditionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PermissionFactory, T1, InnerPermissionConditionFactory> WithConditions<T1>(this CombinedResult<PermissionFactory, T1> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PermissionFactory, InnerPermissionConditionFactory> WithConditions<T1>(this CombinedResult<T1, PermissionFactory> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PermissionFactory, T1, T2, InnerPermissionConditionFactory> WithConditions<T1, T2>(this CombinedResult<PermissionFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PermissionFactory, T2, InnerPermissionConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, PermissionFactory, T2> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PermissionFactory, InnerPermissionConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, PermissionFactory> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PermissionFactory, T1, T2, T3, InnerPermissionConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<PermissionFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PermissionFactory, T2, T3, InnerPermissionConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, PermissionFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PermissionFactory, T3, InnerPermissionConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, PermissionFactory, T3> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PermissionFactory, InnerPermissionConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, PermissionFactory> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PermissionFactory, T1, T2, T3, T4, InnerPermissionConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<PermissionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PermissionFactory, T2, T3, T4, InnerPermissionConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, PermissionFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PermissionFactory, T3, T4, InnerPermissionConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, PermissionFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PermissionFactory, T4, InnerPermissionConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PermissionFactory, T4> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PermissionFactory, InnerPermissionConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PermissionFactory> combinedResult, Action<Humidifier.QBusiness.PermissionTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction).T2);
}
