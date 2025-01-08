// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class GuardHookFactory(string resourceName = null, Action<Humidifier.CloudFormation.GuardHook> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.GuardHook>(resourceName)
{

    internal InnerGuardHookOptionsFactory OptionsFactory { get; set; }

    internal InnerGuardHookS3LocationFactory RuleLocationFactory { get; set; }

    internal InnerGuardHookStackFiltersFactory StackFiltersFactory { get; set; }

    internal InnerGuardHookTargetFiltersFactory TargetFiltersFactory { get; set; }

    protected override Humidifier.CloudFormation.GuardHook Create()
    {
        var guardHookResult = CreateGuardHook();
        factoryAction?.Invoke(guardHookResult);

        return guardHookResult;
    }

    private Humidifier.CloudFormation.GuardHook CreateGuardHook()
    {
        var guardHookResult = new Humidifier.CloudFormation.GuardHook
        {
            GivenName = InputResourceName,
        };

        return guardHookResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.GuardHook result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
        result.RuleLocation ??= RuleLocationFactory?.Build();
        result.StackFilters ??= StackFiltersFactory?.Build();
        result.TargetFilters ??= TargetFiltersFactory?.Build();
    }

} // End Of Class

public static class GuardHookFactoryExtensions
{
    public static CombinedResult<GuardHookFactory, InnerGuardHookOptionsFactory> WithOptions(this GuardHookFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerGuardHookOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<GuardHookFactory, InnerGuardHookS3LocationFactory> WithRuleLocation(this GuardHookFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.RuleLocationFactory = new InnerGuardHookS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleLocationFactory);
    }

    public static CombinedResult<GuardHookFactory, InnerGuardHookStackFiltersFactory> WithStackFilters(this GuardHookFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null)
    {
        parentFactory.StackFiltersFactory = new InnerGuardHookStackFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StackFiltersFactory);
    }

    public static CombinedResult<GuardHookFactory, InnerGuardHookTargetFiltersFactory> WithTargetFilters(this GuardHookFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null)
    {
        parentFactory.TargetFiltersFactory = new InnerGuardHookTargetFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFiltersFactory);
    }

    public static CombinedResult<GuardHookFactory, T1, InnerGuardHookOptionsFactory> WithOptions<T1>(this CombinedResult<GuardHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, InnerGuardHookOptionsFactory> WithOptions<T1>(this CombinedResult<T1, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, InnerGuardHookOptionsFactory> WithOptions<T1, T2>(this CombinedResult<GuardHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, InnerGuardHookOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, GuardHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, InnerGuardHookOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<GuardHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, GuardHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, GuardHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, T4, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<GuardHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, T4, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, GuardHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, T4, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, GuardHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, T4, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GuardHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GuardHookFactory, InnerGuardHookOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, InnerGuardHookS3LocationFactory> WithRuleLocation<T1>(this CombinedResult<GuardHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, InnerGuardHookS3LocationFactory> WithRuleLocation<T1>(this CombinedResult<T1, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2>(this CombinedResult<GuardHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2>(this CombinedResult<T1, GuardHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2>(this CombinedResult<T1, T2, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3>(this CombinedResult<GuardHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3>(this CombinedResult<T1, GuardHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3>(this CombinedResult<T1, T2, GuardHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, T4, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3, T4>(this CombinedResult<GuardHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, T4, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3, T4>(this CombinedResult<T1, GuardHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, T4, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, GuardHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, T4, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GuardHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GuardHookFactory, InnerGuardHookS3LocationFactory> WithRuleLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleLocation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, InnerGuardHookStackFiltersFactory> WithStackFilters<T1>(this CombinedResult<GuardHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, InnerGuardHookStackFiltersFactory> WithStackFilters<T1>(this CombinedResult<T1, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<GuardHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<T1, GuardHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2>(this CombinedResult<T1, T2, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<GuardHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, GuardHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, T2, GuardHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, T4, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<GuardHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, T4, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, GuardHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, T4, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, GuardHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, T4, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GuardHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GuardHookFactory, InnerGuardHookStackFiltersFactory> WithStackFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.StackFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStackFilters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1>(this CombinedResult<GuardHookFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1>(this CombinedResult<T1, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<GuardHookFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<T1, GuardHookFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2>(this CombinedResult<T1, T2, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<GuardHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, GuardHookFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, T2, GuardHookFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GuardHookFactory, T1, T2, T3, T4, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<GuardHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GuardHookFactory, T2, T3, T4, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, GuardHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GuardHookFactory, T3, T4, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, GuardHookFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GuardHookFactory, T4, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GuardHookFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GuardHookFactory, InnerGuardHookTargetFiltersFactory> WithTargetFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GuardHookFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetFilters(combinedResult.T5, subFactoryAction));
}
