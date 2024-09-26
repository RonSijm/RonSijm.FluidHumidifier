// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationHDFSFactory(string resourceName = null, Action<Humidifier.DataSync.LocationHDFS> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationHDFS>(resourceName)
{

    internal List<InnerLocationHDFSNameNodeFactory> NameNodesFactories { get; set; } = [];

    internal InnerLocationHDFSQopConfigurationFactory QopConfigurationFactory { get; set; }

    protected override Humidifier.DataSync.LocationHDFS Create()
    {
        var locationHDFSResult = CreateLocationHDFS();
        factoryAction?.Invoke(locationHDFSResult);

        return locationHDFSResult;
    }

    private Humidifier.DataSync.LocationHDFS CreateLocationHDFS()
    {
        var locationHDFSResult = new Humidifier.DataSync.LocationHDFS
        {
            GivenName = InputResourceName,
        };

        return locationHDFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationHDFS result)
    {
        base.CreateChildren(result);

        result.NameNodes = NameNodesFactories.Any() ? NameNodesFactories.Select(x => x.Build()).ToList() : null;
        result.QopConfiguration ??= QopConfigurationFactory?.Build();
    }

} // End Of Class

public static class LocationHDFSFactoryExtensions
{
    public static CombinedResult<LocationHDFSFactory, InnerLocationHDFSNameNodeFactory> WithNameNodes(this LocationHDFSFactory parentFactory, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null)
    {
        var factory = new InnerLocationHDFSNameNodeFactory(subFactoryAction);
        parentFactory.NameNodesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LocationHDFSFactory, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration(this LocationHDFSFactory parentFactory, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null)
    {
        parentFactory.QopConfigurationFactory = new InnerLocationHDFSQopConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QopConfigurationFactory);
    }

    public static CombinedResult<LocationHDFSFactory, T1, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1>(this CombinedResult<LocationHDFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithNameNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1>(this CombinedResult<T1, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithNameNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2>(this CombinedResult<LocationHDFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2>(this CombinedResult<T1, LocationHDFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2>(this CombinedResult<T1, T2, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, T3, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3>(this CombinedResult<LocationHDFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, T3, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3>(this CombinedResult<T1, LocationHDFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, T3, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3>(this CombinedResult<T1, T2, LocationHDFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationHDFSFactory, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, T3, T4, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3, T4>(this CombinedResult<LocationHDFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, T3, T4, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3, T4>(this CombinedResult<T1, LocationHDFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, T3, T4, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationHDFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationHDFSFactory, T4, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationHDFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationHDFSFactory, InnerLocationHDFSNameNodeFactory> WithNameNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNameNodes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1>(this CombinedResult<LocationHDFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithQopConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1>(this CombinedResult<T1, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithQopConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2>(this CombinedResult<LocationHDFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2>(this CombinedResult<T1, LocationHDFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2>(this CombinedResult<T1, T2, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, T3, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3>(this CombinedResult<LocationHDFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, T3, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3>(this CombinedResult<T1, LocationHDFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, T3, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, LocationHDFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationHDFSFactory, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationHDFSFactory, T1, T2, T3, T4, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3, T4>(this CombinedResult<LocationHDFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationHDFSFactory, T2, T3, T4, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, LocationHDFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationHDFSFactory, T3, T4, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationHDFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationHDFSFactory, T4, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationHDFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationHDFSFactory, InnerLocationHDFSQopConfigurationFactory> WithQopConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationHDFSFactory> combinedResult, Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQopConfiguration(combinedResult.T5, subFactoryAction));
}
