// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class WorkGroupFactory(string resourceName = null, Action<Humidifier.Athena.WorkGroup> factoryAction = null) : ResourceFactory<Humidifier.Athena.WorkGroup>(resourceName)
{

    internal InnerWorkGroupWorkGroupConfigurationFactory WorkGroupConfigurationFactory { get; set; }

    protected override Humidifier.Athena.WorkGroup Create()
    {
        var workGroupResult = CreateWorkGroup();
        factoryAction?.Invoke(workGroupResult);

        return workGroupResult;
    }

    private Humidifier.Athena.WorkGroup CreateWorkGroup()
    {
        var workGroupResult = new Humidifier.Athena.WorkGroup
        {
            GivenName = InputResourceName,
        };

        return workGroupResult;
    }
    public override void CreateChildren(Humidifier.Athena.WorkGroup result)
    {
        base.CreateChildren(result);

        result.WorkGroupConfiguration ??= WorkGroupConfigurationFactory?.Build();
    }

} // End Of Class

public static class WorkGroupFactoryExtensions
{
    public static CombinedResult<WorkGroupFactory, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration(this WorkGroupFactory parentFactory, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null)
    {
        parentFactory.WorkGroupConfigurationFactory = new InnerWorkGroupWorkGroupConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkGroupConfigurationFactory);
    }

    public static CombinedResult<WorkGroupFactory, T1, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1>(this CombinedResult<WorkGroupFactory, T1> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkGroupFactory, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1>(this CombinedResult<T1, WorkGroupFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkGroupFactory, T1, T2, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2>(this CombinedResult<WorkGroupFactory, T1, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkGroupFactory, T2, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2>(this CombinedResult<T1, WorkGroupFactory, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkGroupFactory, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkGroupFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkGroupFactory, T1, T2, T3, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3>(this CombinedResult<WorkGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkGroupFactory, T2, T3, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkGroupFactory, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkGroupFactory, T3, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkGroupFactory, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkGroupFactory, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkGroupFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkGroupFactory, T1, T2, T3, T4, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkGroupFactory, T2, T3, T4, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkGroupFactory, T3, T4, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkGroupFactory, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkGroupFactory, T4, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkGroupFactory, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkGroupFactory, InnerWorkGroupWorkGroupConfigurationFactory> WithWorkGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkGroupFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkGroupConfiguration(combinedResult.T5, subFactoryAction));
}
