// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookOptionsFactory(Action<Humidifier.CloudFormation.GuardHookTypes.Options> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.Options>
{

    internal InnerGuardHookS3LocationFactory InputParamsFactory { get; set; }

    protected override Humidifier.CloudFormation.GuardHookTypes.Options Create()
    {
        var optionsResult = CreateOptions();
        factoryAction?.Invoke(optionsResult);

        return optionsResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.Options CreateOptions()
    {
        var optionsResult = new Humidifier.CloudFormation.GuardHookTypes.Options();

        return optionsResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.GuardHookTypes.Options result)
    {
        base.CreateChildren(result);

        result.InputParams ??= InputParamsFactory?.Build();
    }

} // End Of Class

public static class InnerGuardHookOptionsFactoryExtensions
{
    public static CombinedResult<InnerGuardHookOptionsFactory, InnerGuardHookS3LocationFactory> WithInputParams(this InnerGuardHookOptionsFactory parentFactory, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.InputParamsFactory = new InnerGuardHookS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputParamsFactory);
    }

    public static CombinedResult<InnerGuardHookOptionsFactory, T1, InnerGuardHookS3LocationFactory> WithInputParams<T1>(this CombinedResult<InnerGuardHookOptionsFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookOptionsFactory, InnerGuardHookS3LocationFactory> WithInputParams<T1>(this CombinedResult<T1, InnerGuardHookOptionsFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGuardHookOptionsFactory, T1, T2, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2>(this CombinedResult<InnerGuardHookOptionsFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookOptionsFactory, T2, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2>(this CombinedResult<T1, InnerGuardHookOptionsFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookOptionsFactory, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2>(this CombinedResult<T1, T2, InnerGuardHookOptionsFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGuardHookOptionsFactory, T1, T2, T3, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3>(this CombinedResult<InnerGuardHookOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookOptionsFactory, T2, T3, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3>(this CombinedResult<T1, InnerGuardHookOptionsFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookOptionsFactory, T3, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3>(this CombinedResult<T1, T2, InnerGuardHookOptionsFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookOptionsFactory, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGuardHookOptionsFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGuardHookOptionsFactory, T1, T2, T3, T4, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3, T4>(this CombinedResult<InnerGuardHookOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGuardHookOptionsFactory, T2, T3, T4, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3, T4>(this CombinedResult<T1, InnerGuardHookOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGuardHookOptionsFactory, T3, T4, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGuardHookOptionsFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGuardHookOptionsFactory, T4, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGuardHookOptionsFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGuardHookOptionsFactory, InnerGuardHookS3LocationFactory> WithInputParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGuardHookOptionsFactory> combinedResult, Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputParams(combinedResult.T5, subFactoryAction));
}
