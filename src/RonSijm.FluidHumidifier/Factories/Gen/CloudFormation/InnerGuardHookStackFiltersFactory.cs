// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookStackFiltersFactory(Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.StackFilters>
{

    internal InnerGuardHookStackNamesFactory StackNamesFactory { get; set; }

    internal InnerGuardHookStackRolesFactory StackRolesFactory { get; set; }

    protected override Humidifier.CloudFormation.GuardHookTypes.StackFilters Create()
    {
        var stackFiltersResult = CreateStackFilters();
        factoryAction?.Invoke(stackFiltersResult);

        return stackFiltersResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.StackFilters CreateStackFilters()
    {
        var stackFiltersResult = new Humidifier.CloudFormation.GuardHookTypes.StackFilters();

        return stackFiltersResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.GuardHookTypes.StackFilters result)
    {
        base.CreateChildren(result);

        result.StackNames ??= StackNamesFactory?.Build();
        result.StackRoles ??= StackRolesFactory?.Build();
    }

} // End Of Class

public static class InnerGuardHookStackFiltersFactoryExtensions
{
    public static CombinedResult<InnerGuardHookStackFiltersFactory, InnerGuardHookStackNamesFactory> WithStackNames(this InnerGuardHookStackFiltersFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null)
    {
        parentFactory.StackNamesFactory = new InnerGuardHookStackNamesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackNamesFactory);
    }

    public static CombinedResult<InnerGuardHookStackFiltersFactory, InnerGuardHookStackRolesFactory> WithStackRoles(this InnerGuardHookStackFiltersFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null)
    {
        parentFactory.StackRolesFactory = new InnerGuardHookStackRolesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackRolesFactory);
    }

    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, InnerGuardHookStackNamesFactory> WithStackNames<T1>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, InnerGuardHookStackNamesFactory> WithStackNames<T1>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, T4, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, T4, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, T4, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, T4, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGuardHookStackFiltersFactory, InnerGuardHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, InnerGuardHookStackRolesFactory> WithStackRoles<T1>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, InnerGuardHookStackRolesFactory> WithStackRoles<T1>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, T4, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<InnerGuardHookStackFiltersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, T4, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, InnerGuardHookStackFiltersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, T4, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGuardHookStackFiltersFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, T4, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGuardHookStackFiltersFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGuardHookStackFiltersFactory, InnerGuardHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGuardHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T5, subFactoryAction));
}
