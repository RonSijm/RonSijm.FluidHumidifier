// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class StudioFactory(string resourceName = null, Action<Humidifier.NimbleStudio.Studio> factoryAction = null) : ResourceFactory<Humidifier.NimbleStudio.Studio>(resourceName)
{

    internal InnerStudioStudioEncryptionConfigurationFactory StudioEncryptionConfigurationFactory { get; set; }

    protected override Humidifier.NimbleStudio.Studio Create()
    {
        var studioResult = CreateStudio();
        factoryAction?.Invoke(studioResult);

        return studioResult;
    }

    private Humidifier.NimbleStudio.Studio CreateStudio()
    {
        var studioResult = new Humidifier.NimbleStudio.Studio
        {
            GivenName = InputResourceName,
        };

        return studioResult;
    }
    public override void CreateChildren(Humidifier.NimbleStudio.Studio result)
    {
        base.CreateChildren(result);

        result.StudioEncryptionConfiguration ??= StudioEncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class StudioFactoryExtensions
{
    public static CombinedResult<StudioFactory, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration(this StudioFactory parentFactory, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.StudioEncryptionConfigurationFactory = new InnerStudioStudioEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StudioEncryptionConfigurationFactory);
    }

    public static CombinedResult<StudioFactory, T1, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1>(this CombinedResult<StudioFactory, T1> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StudioFactory, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1>(this CombinedResult<T1, StudioFactory> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StudioFactory, T1, T2, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2>(this CombinedResult<StudioFactory, T1, T2> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StudioFactory, T2, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2>(this CombinedResult<T1, StudioFactory, T2> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StudioFactory, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, StudioFactory> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StudioFactory, T1, T2, T3, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3>(this CombinedResult<StudioFactory, T1, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StudioFactory, T2, T3, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, StudioFactory, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StudioFactory, T3, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StudioFactory, T3> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StudioFactory, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StudioFactory> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StudioFactory, T1, T2, T3, T4, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<StudioFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StudioFactory, T2, T3, T4, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StudioFactory, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StudioFactory, T3, T4, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StudioFactory, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StudioFactory, T4, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StudioFactory, T4> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StudioFactory, InnerStudioStudioEncryptionConfigurationFactory> WithStudioEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StudioFactory> combinedResult, Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStudioEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
