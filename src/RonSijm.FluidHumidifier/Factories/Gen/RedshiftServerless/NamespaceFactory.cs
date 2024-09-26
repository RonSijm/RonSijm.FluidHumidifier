// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class NamespaceFactory(string resourceName = null, Action<Humidifier.RedshiftServerless.Namespace> factoryAction = null) : ResourceFactory<Humidifier.RedshiftServerless.Namespace>(resourceName)
{

    internal List<InnerNamespaceSnapshotCopyConfigurationFactory> SnapshotCopyConfigurationsFactories { get; set; } = [];

    protected override Humidifier.RedshiftServerless.Namespace Create()
    {
        var namespaceResult = CreateNamespace();
        factoryAction?.Invoke(namespaceResult);

        return namespaceResult;
    }

    private Humidifier.RedshiftServerless.Namespace CreateNamespace()
    {
        var namespaceResult = new Humidifier.RedshiftServerless.Namespace
        {
            GivenName = InputResourceName,
        };

        return namespaceResult;
    }
    public override void CreateChildren(Humidifier.RedshiftServerless.Namespace result)
    {
        base.CreateChildren(result);

        result.SnapshotCopyConfigurations = SnapshotCopyConfigurationsFactories.Any() ? SnapshotCopyConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NamespaceFactoryExtensions
{
    public static CombinedResult<NamespaceFactory, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations(this NamespaceFactory parentFactory, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null)
    {
        var factory = new InnerNamespaceSnapshotCopyConfigurationFactory(subFactoryAction);
        parentFactory.SnapshotCopyConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NamespaceFactory, T1, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1>(this CombinedResult<NamespaceFactory, T1> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NamespaceFactory, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1>(this CombinedResult<T1, NamespaceFactory> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NamespaceFactory, T1, T2, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2>(this CombinedResult<NamespaceFactory, T1, T2> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NamespaceFactory, T2, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2>(this CombinedResult<T1, NamespaceFactory, T2> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NamespaceFactory, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2>(this CombinedResult<T1, T2, NamespaceFactory> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NamespaceFactory, T1, T2, T3, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3>(this CombinedResult<NamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NamespaceFactory, T2, T3, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3>(this CombinedResult<T1, NamespaceFactory, T2, T3> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NamespaceFactory, T3, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, NamespaceFactory, T3> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NamespaceFactory, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, NamespaceFactory> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NamespaceFactory, T1, T2, T3, T4, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3, T4>(this CombinedResult<NamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NamespaceFactory, T2, T3, T4, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, NamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NamespaceFactory, T3, T4, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, NamespaceFactory, T3, T4> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NamespaceFactory, T4, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NamespaceFactory, T4> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NamespaceFactory, InnerNamespaceSnapshotCopyConfigurationFactory> WithSnapshotCopyConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NamespaceFactory> combinedResult, Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnapshotCopyConfigurations(combinedResult.T5, subFactoryAction));
}
