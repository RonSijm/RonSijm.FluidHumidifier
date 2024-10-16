// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class VolumeFactory(string resourceName = null, Action<Humidifier.FSx.Volume> factoryAction = null) : ResourceFactory<Humidifier.FSx.Volume>(resourceName)
{

    internal InnerVolumeOpenZFSConfigurationFactory OpenZFSConfigurationFactory { get; set; }

    internal InnerVolumeOntapConfigurationFactory OntapConfigurationFactory { get; set; }

    protected override Humidifier.FSx.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.FSx.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.FSx.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }
    public override void CreateChildren(Humidifier.FSx.Volume result)
    {
        base.CreateChildren(result);

        result.OpenZFSConfiguration ??= OpenZFSConfigurationFactory?.Build();
        result.OntapConfiguration ??= OntapConfigurationFactory?.Build();
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
    public static CombinedResult<VolumeFactory, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration(this VolumeFactory parentFactory, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null)
    {
        parentFactory.OpenZFSConfigurationFactory = new InnerVolumeOpenZFSConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenZFSConfigurationFactory);
    }

    public static CombinedResult<VolumeFactory, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration(this VolumeFactory parentFactory, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null)
    {
        parentFactory.OntapConfigurationFactory = new InnerVolumeOntapConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OntapConfigurationFactory);
    }

    public static CombinedResult<VolumeFactory, T1, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1>(this CombinedResult<VolumeFactory, T1> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1>(this CombinedResult<T1, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<VolumeFactory, T1, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<T1, VolumeFactory, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2>(this CombinedResult<T1, T2, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, T3, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<VolumeFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, T3, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, VolumeFactory, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, T3, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, VolumeFactory, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VolumeFactory, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, T3, T4, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<VolumeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, T3, T4, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, VolumeFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, T3, T4, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, VolumeFactory, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VolumeFactory, T4, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VolumeFactory, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VolumeFactory, InnerVolumeOpenZFSConfigurationFactory> WithOpenZFSConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenZFSConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1>(this CombinedResult<VolumeFactory, T1> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1>(this CombinedResult<T1, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<VolumeFactory, T1, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<T1, VolumeFactory, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2>(this CombinedResult<T1, T2, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, T3, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<VolumeFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, T3, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, VolumeFactory, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, T3, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, VolumeFactory, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VolumeFactory, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VolumeFactory, T1, T2, T3, T4, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<VolumeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VolumeFactory, T2, T3, T4, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, VolumeFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VolumeFactory, T3, T4, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, VolumeFactory, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VolumeFactory, T4, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VolumeFactory, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VolumeFactory, InnerVolumeOntapConfigurationFactory> WithOntapConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VolumeFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OntapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOntapConfiguration(combinedResult.T5, subFactoryAction));
}
