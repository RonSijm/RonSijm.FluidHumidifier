// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainMatchingFactory(Action<Humidifier.CustomerProfiles.DomainTypes.Matching> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.Matching>
{

    internal InnerDomainAutoMergingFactory AutoMergingFactory { get; set; }

    internal InnerDomainJobScheduleFactory JobScheduleFactory { get; set; }

    internal InnerDomainExportingConfigFactory ExportingConfigFactory { get; set; }

    protected override Humidifier.CustomerProfiles.DomainTypes.Matching Create()
    {
        var matchingResult = CreateMatching();
        factoryAction?.Invoke(matchingResult);

        return matchingResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.Matching CreateMatching()
    {
        var matchingResult = new Humidifier.CustomerProfiles.DomainTypes.Matching();

        return matchingResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.DomainTypes.Matching result)
    {
        base.CreateChildren(result);

        result.AutoMerging ??= AutoMergingFactory?.Build();
        result.JobSchedule ??= JobScheduleFactory?.Build();
        result.ExportingConfig ??= ExportingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDomainMatchingFactoryExtensions
{
    public static CombinedResult<InnerDomainMatchingFactory, InnerDomainAutoMergingFactory> WithAutoMerging(this InnerDomainMatchingFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null)
    {
        parentFactory.AutoMergingFactory = new InnerDomainAutoMergingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoMergingFactory);
    }

    public static CombinedResult<InnerDomainMatchingFactory, InnerDomainJobScheduleFactory> WithJobSchedule(this InnerDomainMatchingFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null)
    {
        parentFactory.JobScheduleFactory = new InnerDomainJobScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobScheduleFactory);
    }

    public static CombinedResult<InnerDomainMatchingFactory, InnerDomainExportingConfigFactory> WithExportingConfig(this InnerDomainMatchingFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null)
    {
        parentFactory.ExportingConfigFactory = new InnerDomainExportingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportingConfigFactory);
    }

    public static CombinedResult<InnerDomainMatchingFactory, T1, InnerDomainAutoMergingFactory> WithAutoMerging<T1>(this CombinedResult<InnerDomainMatchingFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoMerging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, InnerDomainAutoMergingFactory> WithAutoMerging<T1>(this CombinedResult<T1, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoMerging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2>(this CombinedResult<InnerDomainMatchingFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2>(this CombinedResult<T1, InnerDomainMatchingFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2>(this CombinedResult<T1, T2, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3, T4>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory, InnerDomainAutoMergingFactory> WithAutoMerging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMerging(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, InnerDomainJobScheduleFactory> WithJobSchedule<T1>(this CombinedResult<InnerDomainMatchingFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, InnerDomainJobScheduleFactory> WithJobSchedule<T1>(this CombinedResult<T1, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2>(this CombinedResult<InnerDomainMatchingFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2>(this CombinedResult<T1, InnerDomainMatchingFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2>(this CombinedResult<T1, T2, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3, T4>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory, InnerDomainJobScheduleFactory> WithJobSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobSchedule(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, InnerDomainExportingConfigFactory> WithExportingConfig<T1>(this CombinedResult<InnerDomainMatchingFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, InnerDomainExportingConfigFactory> WithExportingConfig<T1>(this CombinedResult<T1, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2>(this CombinedResult<InnerDomainMatchingFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2>(this CombinedResult<T1, InnerDomainMatchingFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2>(this CombinedResult<T1, T2, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3, T4>(this CombinedResult<InnerDomainMatchingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainMatchingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainMatchingFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainMatchingFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory, InnerDomainExportingConfigFactory> WithExportingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainMatchingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportingConfig(combinedResult.T5, subFactoryAction));
}
