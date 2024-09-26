// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCZonalShift;

public class ZonalAutoshiftConfigurationFactory(string resourceName = null, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration>(resourceName)
{

    internal InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory PracticeRunConfigurationFactory { get; set; }

    protected override Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration Create()
    {
        var zonalAutoshiftConfigurationResult = CreateZonalAutoshiftConfiguration();
        factoryAction?.Invoke(zonalAutoshiftConfigurationResult);

        return zonalAutoshiftConfigurationResult;
    }

    private Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration CreateZonalAutoshiftConfiguration()
    {
        var zonalAutoshiftConfigurationResult = new Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration
        {
            GivenName = InputResourceName,
        };

        return zonalAutoshiftConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ARCZonalShift.ZonalAutoshiftConfiguration result)
    {
        base.CreateChildren(result);

        result.PracticeRunConfiguration ??= PracticeRunConfigurationFactory?.Build();
    }

} // End Of Class

public static class ZonalAutoshiftConfigurationFactoryExtensions
{
    public static CombinedResult<ZonalAutoshiftConfigurationFactory, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration(this ZonalAutoshiftConfigurationFactory parentFactory, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null)
    {
        parentFactory.PracticeRunConfigurationFactory = new InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PracticeRunConfigurationFactory);
    }

    public static CombinedResult<ZonalAutoshiftConfigurationFactory, T1, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1>(this CombinedResult<ZonalAutoshiftConfigurationFactory, T1> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ZonalAutoshiftConfigurationFactory, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1>(this CombinedResult<T1, ZonalAutoshiftConfigurationFactory> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2>(this CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2>(this CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2>(this CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2, T3, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3>(this CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2, T3, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3>(this CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory, T3, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory, T3> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ZonalAutoshiftConfigurationFactory, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ZonalAutoshiftConfigurationFactory> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2, T3, T4, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3, T4>(this CombinedResult<ZonalAutoshiftConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2, T3, T4, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ZonalAutoshiftConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory, T3, T4, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ZonalAutoshiftConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ZonalAutoshiftConfigurationFactory, T4, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ZonalAutoshiftConfigurationFactory, T4> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ZonalAutoshiftConfigurationFactory, InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory> WithPracticeRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ZonalAutoshiftConfigurationFactory> combinedResult, Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPracticeRunConfiguration(combinedResult.T5, subFactoryAction));
}
