// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeSnaplockConfigurationFactory(Action<Humidifier.FSx.VolumeTypes.SnaplockConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.SnaplockConfiguration>
{

    internal InnerVolumeAutocommitPeriodFactory AutocommitPeriodFactory { get; set; }

    internal InnerVolumeSnaplockRetentionPeriodFactory RetentionPeriodFactory { get; set; }

    protected override Humidifier.FSx.VolumeTypes.SnaplockConfiguration Create()
    {
        var snaplockConfigurationResult = CreateSnaplockConfiguration();
        factoryAction?.Invoke(snaplockConfigurationResult);

        return snaplockConfigurationResult;
    }

    private Humidifier.FSx.VolumeTypes.SnaplockConfiguration CreateSnaplockConfiguration()
    {
        var snaplockConfigurationResult = new Humidifier.FSx.VolumeTypes.SnaplockConfiguration();

        return snaplockConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.VolumeTypes.SnaplockConfiguration result)
    {
        base.CreateChildren(result);

        result.AutocommitPeriod ??= AutocommitPeriodFactory?.Build();
        result.RetentionPeriod ??= RetentionPeriodFactory?.Build();
    }

} // End Of Class

public static class InnerVolumeSnaplockConfigurationFactoryExtensions
{
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod(this InnerVolumeSnaplockConfigurationFactory parentFactory, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null)
    {
        parentFactory.AutocommitPeriodFactory = new InnerVolumeAutocommitPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutocommitPeriodFactory);
    }

    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod(this InnerVolumeSnaplockConfigurationFactory parentFactory, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null)
    {
        parentFactory.RetentionPeriodFactory = new InnerVolumeSnaplockRetentionPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionPeriodFactory);
    }

    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, T4, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3, T4>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, T4, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3, T4>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, T4, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, T4, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVolumeSnaplockConfigurationFactory, InnerVolumeAutocommitPeriodFactory> WithAutocommitPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.AutocommitPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutocommitPeriod(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, T4, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<InnerVolumeSnaplockConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, T4, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, InnerVolumeSnaplockConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, T4, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVolumeSnaplockConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, T4, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVolumeSnaplockConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVolumeSnaplockConfigurationFactory, InnerVolumeSnaplockRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVolumeSnaplockConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T5, subFactoryAction));
}
