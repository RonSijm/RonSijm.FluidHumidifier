// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerJobJobActionOptionsFactory(Action<Humidifier.Location.JobTypes.JobActionOptions> factoryAction = null) : SubResourceFactory<Humidifier.Location.JobTypes.JobActionOptions>
{

    internal InnerJobValidateAddressActionOptionsFactory ValidateAddressFactory { get; set; }

    protected override Humidifier.Location.JobTypes.JobActionOptions Create()
    {
        var jobActionOptionsResult = CreateJobActionOptions();
        factoryAction?.Invoke(jobActionOptionsResult);

        return jobActionOptionsResult;
    }

    private Humidifier.Location.JobTypes.JobActionOptions CreateJobActionOptions()
    {
        var jobActionOptionsResult = new Humidifier.Location.JobTypes.JobActionOptions();

        return jobActionOptionsResult;
    }
    public override void CreateChildren(Humidifier.Location.JobTypes.JobActionOptions result)
    {
        base.CreateChildren(result);

        result.ValidateAddress ??= ValidateAddressFactory?.Build();
    }

} // End Of Class

public static class InnerJobJobActionOptionsFactoryExtensions
{
    public static CombinedResult<InnerJobJobActionOptionsFactory, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress(this InnerJobJobActionOptionsFactory parentFactory, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null)
    {
        parentFactory.ValidateAddressFactory = new InnerJobValidateAddressActionOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidateAddressFactory);
    }

    public static CombinedResult<InnerJobJobActionOptionsFactory, T1, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1>(this CombinedResult<InnerJobJobActionOptionsFactory, T1> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidateAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobActionOptionsFactory, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1>(this CombinedResult<T1, InnerJobJobActionOptionsFactory> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidateAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobActionOptionsFactory, T1, T2, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2>(this CombinedResult<InnerJobJobActionOptionsFactory, T1, T2> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobActionOptionsFactory, T2, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2>(this CombinedResult<T1, InnerJobJobActionOptionsFactory, T2> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobActionOptionsFactory, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2>(this CombinedResult<T1, T2, InnerJobJobActionOptionsFactory> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobActionOptionsFactory, T1, T2, T3, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3>(this CombinedResult<InnerJobJobActionOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobActionOptionsFactory, T2, T3, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3>(this CombinedResult<T1, InnerJobJobActionOptionsFactory, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobActionOptionsFactory, T3, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobActionOptionsFactory, T3> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobActionOptionsFactory, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobActionOptionsFactory> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobActionOptionsFactory, T1, T2, T3, T4, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3, T4>(this CombinedResult<InnerJobJobActionOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobActionOptionsFactory, T2, T3, T4, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobActionOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobActionOptionsFactory, T3, T4, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobActionOptionsFactory, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobActionOptionsFactory, T4, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobActionOptionsFactory, T4> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobActionOptionsFactory, InnerJobValidateAddressActionOptionsFactory> WithValidateAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobActionOptionsFactory> combinedResult, Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidateAddress(combinedResult.T5, subFactoryAction).T2);
}
