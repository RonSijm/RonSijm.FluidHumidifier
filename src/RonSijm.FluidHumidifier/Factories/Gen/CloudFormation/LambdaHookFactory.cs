// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class LambdaHookFactory(string resourceName = null, Action<Humidifier.CloudFormation.LambdaHook> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.LambdaHook>(resourceName)
{

    internal InnerLambdaHookStackFiltersFactory StackFiltersFactory { get; set; }

    internal InnerLambdaHookTargetFiltersFactory TargetFiltersFactory { get; set; }

    protected override Humidifier.CloudFormation.LambdaHook Create()
    {
        var lambdaHookResult = CreateLambdaHook();
        factoryAction?.Invoke(lambdaHookResult);

        return lambdaHookResult;
    }

    private Humidifier.CloudFormation.LambdaHook CreateLambdaHook()
    {
        var lambdaHookResult = new Humidifier.CloudFormation.LambdaHook
        {
            GivenName = InputResourceName,
        };

        return lambdaHookResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.LambdaHook result)
    {
        base.CreateChildren(result);

        result.StackFilters ??= StackFiltersFactory?.Build();
        result.TargetFilters ??= TargetFiltersFactory?.Build();
    }

} // End Of Class

public static class LambdaHookFactoryExtensions
{
    public static CombinedResult<LambdaHookFactory, InnerLambdaHookStackFiltersFactory> WithStackFilters(this LambdaHookFactory parentFactory, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null)
    {
        parentFactory.StackFiltersFactory = new InnerLambdaHookStackFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackFiltersFactory);
    }

    public static CombinedResult<LambdaHookFactory, InnerLambdaHookTargetFiltersFactory> WithTargetFilters(this LambdaHookFactory parentFactory, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null)
    {
        parentFactory.TargetFiltersFactory = new InnerLambdaHookTargetFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFiltersFactory);
    }

    public static CombinedResult<LambdaHookFactory, T1, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1>(this CombinedResult<LambdaHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1>(this CombinedResult<T1, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<LambdaHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<T1, LambdaHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<T1, T2, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, T3, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<LambdaHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, T3, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, LambdaHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, T3, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, T2, LambdaHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LambdaHookFactory, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, T3, T4, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<LambdaHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, T3, T4, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, LambdaHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, T3, T4, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, LambdaHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LambdaHookFactory, T4, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LambdaHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LambdaHookFactory, InnerLambdaHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1>(this CombinedResult<LambdaHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1>(this CombinedResult<T1, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<LambdaHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<T1, LambdaHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<T1, T2, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, T3, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<LambdaHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, T3, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, LambdaHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, T3, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, T2, LambdaHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LambdaHookFactory, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LambdaHookFactory, T1, T2, T3, T4, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<LambdaHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LambdaHookFactory, T2, T3, T4, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, LambdaHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LambdaHookFactory, T3, T4, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, LambdaHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LambdaHookFactory, T4, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LambdaHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LambdaHookFactory, InnerLambdaHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LambdaHookFactory> combinedResult, Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T5, subFactoryAction));
}
