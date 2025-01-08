// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerLambdaHookStackFiltersFactory(Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.LambdaHookTypes.StackFilters>
{

    internal InnerLambdaHookStackNamesFactory StackNamesFactory { get; set; }

    internal InnerLambdaHookStackRolesFactory StackRolesFactory { get; set; }

    protected override Humidifier.CloudFormation.LambdaHookTypes.StackFilters Create()
    {
        var stackFiltersResult = CreateStackFilters();
        factoryAction?.Invoke(stackFiltersResult);

        return stackFiltersResult;
    }

    private Humidifier.CloudFormation.LambdaHookTypes.StackFilters CreateStackFilters()
    {
        var stackFiltersResult = new Humidifier.CloudFormation.LambdaHookTypes.StackFilters();

        return stackFiltersResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.LambdaHookTypes.StackFilters result)
    {
        base.CreateChildren(result);

        result.StackNames ??= StackNamesFactory?.Build();
        result.StackRoles ??= StackRolesFactory?.Build();
    }

} // End Of Class

public static class InnerLambdaHookStackFiltersFactoryExtensions
{
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackNamesFactory> WithStackNames(this InnerLambdaHookStackFiltersFactory parentFactory, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null)
    {
        parentFactory.StackNamesFactory = new InnerLambdaHookStackNamesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackNamesFactory);
    }

    public static CombinedResult<InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackRolesFactory> WithStackRoles(this InnerLambdaHookStackFiltersFactory parentFactory, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null)
    {
        parentFactory.StackRolesFactory = new InnerLambdaHookStackRolesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackRolesFactory);
    }

    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, InnerLambdaHookStackNamesFactory> WithStackNames<T1>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackNamesFactory> WithStackNames<T1>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, T4, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, T4, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, T4, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, T4, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackNamesFactory> WithStackNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackNames(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, InnerLambdaHookStackRolesFactory> WithStackRoles<T1>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackRolesFactory> WithStackRoles<T1>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, T4, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<InnerLambdaHookStackFiltersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, T4, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, InnerLambdaHookStackFiltersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, T4, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLambdaHookStackFiltersFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, T4, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLambdaHookStackFiltersFactory, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLambdaHookStackFiltersFactory, InnerLambdaHookStackRolesFactory> WithStackRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLambdaHookStackFiltersFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackRoles(combinedResult.T5, subFactoryAction));
}
