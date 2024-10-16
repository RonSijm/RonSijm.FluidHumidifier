// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InfrastructureConfigurationFactory(string resourceName = null, Action<Humidifier.ImageBuilder.InfrastructureConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.InfrastructureConfiguration>(resourceName)
{

    internal InnerInfrastructureConfigurationLoggingFactory LoggingFactory { get; set; }

    internal InnerInfrastructureConfigurationInstanceMetadataOptionsFactory InstanceMetadataOptionsFactory { get; set; }

    protected override Humidifier.ImageBuilder.InfrastructureConfiguration Create()
    {
        var infrastructureConfigurationResult = CreateInfrastructureConfiguration();
        factoryAction?.Invoke(infrastructureConfigurationResult);

        return infrastructureConfigurationResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfiguration CreateInfrastructureConfiguration()
    {
        var infrastructureConfigurationResult = new Humidifier.ImageBuilder.InfrastructureConfiguration
        {
            GivenName = InputResourceName,
        };

        return infrastructureConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.InfrastructureConfiguration result)
    {
        base.CreateChildren(result);

        result.Logging ??= LoggingFactory?.Build();
        result.InstanceMetadataOptions ??= InstanceMetadataOptionsFactory?.Build();
    }

} // End Of Class

public static class InfrastructureConfigurationFactoryExtensions
{
    public static CombinedResult<InfrastructureConfigurationFactory, InnerInfrastructureConfigurationLoggingFactory> WithLogging(this InfrastructureConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null)
    {
        parentFactory.LoggingFactory = new InnerInfrastructureConfigurationLoggingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingFactory);
    }

    public static CombinedResult<InfrastructureConfigurationFactory, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions(this InfrastructureConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null)
    {
        parentFactory.InstanceMetadataOptionsFactory = new InnerInfrastructureConfigurationInstanceMetadataOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InstanceMetadataOptionsFactory);
    }

    public static CombinedResult<InfrastructureConfigurationFactory, T1, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1>(this CombinedResult<InfrastructureConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1>(this CombinedResult<T1, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, T4, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3, T4>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, T4, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3, T4>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, T4, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, T4, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationLoggingFactory> WithLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogging(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1>(this CombinedResult<InfrastructureConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1>(this CombinedResult<T1, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, T4, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3, T4>(this CombinedResult<InfrastructureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, T4, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, InfrastructureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, T4, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfrastructureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, T4, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfrastructureConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InfrastructureConfigurationFactory, InnerInfrastructureConfigurationInstanceMetadataOptionsFactory> WithInstanceMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfrastructureConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataOptions(combinedResult.T5, subFactoryAction));
}
