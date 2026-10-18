// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSrtCallerRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration>
{

    internal InnerRouterInputSrtDecryptionConfigurationFactory DecryptionConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration Create()
    {
        var srtCallerRouterInputConfigurationResult = CreateSrtCallerRouterInputConfiguration();
        factoryAction?.Invoke(srtCallerRouterInputConfigurationResult);

        return srtCallerRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration CreateSrtCallerRouterInputConfiguration()
    {
        var srtCallerRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration();

        return srtCallerRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.DecryptionConfiguration ??= DecryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputSrtCallerRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration(this InnerRouterInputSrtCallerRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.DecryptionConfigurationFactory = new InnerRouterInputSrtDecryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1>(this CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1>(this CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtCallerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtCallerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputSrtCallerRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtCallerRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtCallerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtCallerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
