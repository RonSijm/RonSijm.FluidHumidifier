// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class ProtectionFactory(string resourceName = null, Action<Humidifier.Shield.Protection> factoryAction = null) : ResourceFactory<Humidifier.Shield.Protection>(resourceName)
{

    internal InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory ApplicationLayerAutomaticResponseConfigurationFactory { get; set; }

    protected override Humidifier.Shield.Protection Create()
    {
        var protectionResult = CreateProtection();
        factoryAction?.Invoke(protectionResult);

        return protectionResult;
    }

    private Humidifier.Shield.Protection CreateProtection()
    {
        var protectionResult = new Humidifier.Shield.Protection
        {
            GivenName = InputResourceName,
        };

        return protectionResult;
    }
    public override void CreateChildren(Humidifier.Shield.Protection result)
    {
        base.CreateChildren(result);

        result.ApplicationLayerAutomaticResponseConfiguration ??= ApplicationLayerAutomaticResponseConfigurationFactory?.Build();
    }

} // End Of Class

public static class ProtectionFactoryExtensions
{
    public static CombinedResult<ProtectionFactory, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration(this ProtectionFactory parentFactory, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null)
    {
        parentFactory.ApplicationLayerAutomaticResponseConfigurationFactory = new InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationLayerAutomaticResponseConfigurationFactory);
    }

    public static CombinedResult<ProtectionFactory, T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1>(this CombinedResult<ProtectionFactory, T1> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProtectionFactory, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1>(this CombinedResult<T1, ProtectionFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProtectionFactory, T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2>(this CombinedResult<ProtectionFactory, T1, T2> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProtectionFactory, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2>(this CombinedResult<T1, ProtectionFactory, T2> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProtectionFactory, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2>(this CombinedResult<T1, T2, ProtectionFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProtectionFactory, T1, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3>(this CombinedResult<ProtectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProtectionFactory, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3>(this CombinedResult<T1, ProtectionFactory, T2, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProtectionFactory, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ProtectionFactory, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProtectionFactory, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProtectionFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProtectionFactory, T1, T2, T3, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3, T4>(this CombinedResult<ProtectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProtectionFactory, T2, T3, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ProtectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProtectionFactory, T3, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProtectionFactory, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProtectionFactory, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProtectionFactory, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProtectionFactory, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> WithApplicationLayerAutomaticResponseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProtectionFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLayerAutomaticResponseConfiguration(combinedResult.T5, subFactoryAction));
}
