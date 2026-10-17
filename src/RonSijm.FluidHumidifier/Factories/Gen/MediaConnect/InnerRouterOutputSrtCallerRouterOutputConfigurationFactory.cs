// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSrtCallerRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration>
{

    internal InnerRouterOutputSrtEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration Create()
    {
        var srtCallerRouterOutputConfigurationResult = CreateSrtCallerRouterOutputConfiguration();
        factoryAction?.Invoke(srtCallerRouterOutputConfigurationResult);

        return srtCallerRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration CreateSrtCallerRouterOutputConfiguration()
    {
        var srtCallerRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration();

        return srtCallerRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputSrtCallerRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerRouterOutputSrtCallerRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerRouterOutputSrtEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtCallerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
