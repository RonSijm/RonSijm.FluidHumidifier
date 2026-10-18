// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class TieringConfigurationFactory(string resourceName = null, Action<Humidifier.Backup.TieringConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Backup.TieringConfiguration>(resourceName)
{

    internal List<InnerTieringConfigurationResourceSelectionFactory> ResourceSelectionFactories { get; set; } = [];

    protected override Humidifier.Backup.TieringConfiguration Create()
    {
        var tieringConfigurationResult = CreateTieringConfiguration();
        factoryAction?.Invoke(tieringConfigurationResult);

        return tieringConfigurationResult;
    }

    private Humidifier.Backup.TieringConfiguration CreateTieringConfiguration()
    {
        var tieringConfigurationResult = new Humidifier.Backup.TieringConfiguration
        {
            GivenName = InputResourceName,
        };

        return tieringConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Backup.TieringConfiguration result)
    {
        base.CreateChildren(result);

        result.ResourceSelection = ResourceSelectionFactories.Any() ? ResourceSelectionFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TieringConfigurationFactoryExtensions
{
    public static CombinedResult<TieringConfigurationFactory, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection(this TieringConfigurationFactory parentFactory, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null)
    {
        var factory = new InnerTieringConfigurationResourceSelectionFactory(subFactoryAction);
        parentFactory.ResourceSelectionFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TieringConfigurationFactory, T1, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1>(this CombinedResult<TieringConfigurationFactory, T1> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TieringConfigurationFactory, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1>(this CombinedResult<T1, TieringConfigurationFactory> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TieringConfigurationFactory, T1, T2, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<TieringConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TieringConfigurationFactory, T2, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<T1, TieringConfigurationFactory, T2> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TieringConfigurationFactory, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<T1, T2, TieringConfigurationFactory> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TieringConfigurationFactory, T1, T2, T3, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<TieringConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TieringConfigurationFactory, T2, T3, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, TieringConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TieringConfigurationFactory, T3, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, T2, TieringConfigurationFactory, T3> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TieringConfigurationFactory, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, TieringConfigurationFactory> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TieringConfigurationFactory, T1, T2, T3, T4, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<TieringConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TieringConfigurationFactory, T2, T3, T4, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, TieringConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TieringConfigurationFactory, T3, T4, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, TieringConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TieringConfigurationFactory, T4, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TieringConfigurationFactory, T4> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TieringConfigurationFactory, InnerTieringConfigurationResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TieringConfigurationFactory> combinedResult, Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T5, subFactoryAction).T2);
}
