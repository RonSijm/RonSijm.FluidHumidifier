// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class SourceApiAssociationFactory(string resourceName = null, Action<Humidifier.AppSync.SourceApiAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppSync.SourceApiAssociation>(resourceName)
{

    internal InnerSourceApiAssociationSourceApiAssociationConfigFactory SourceApiAssociationConfigFactory { get; set; }

    protected override Humidifier.AppSync.SourceApiAssociation Create()
    {
        var sourceApiAssociationResult = CreateSourceApiAssociation();
        factoryAction?.Invoke(sourceApiAssociationResult);

        return sourceApiAssociationResult;
    }

    private Humidifier.AppSync.SourceApiAssociation CreateSourceApiAssociation()
    {
        var sourceApiAssociationResult = new Humidifier.AppSync.SourceApiAssociation
        {
            GivenName = InputResourceName,
        };

        return sourceApiAssociationResult;
    }
    public override void CreateChildren(Humidifier.AppSync.SourceApiAssociation result)
    {
        base.CreateChildren(result);

        result.SourceApiAssociationConfig ??= SourceApiAssociationConfigFactory?.Build();
    }

} // End Of Class

public static class SourceApiAssociationFactoryExtensions
{
    public static CombinedResult<SourceApiAssociationFactory, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig(this SourceApiAssociationFactory parentFactory, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null)
    {
        parentFactory.SourceApiAssociationConfigFactory = new InnerSourceApiAssociationSourceApiAssociationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceApiAssociationConfigFactory);
    }

    public static CombinedResult<SourceApiAssociationFactory, T1, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1>(this CombinedResult<SourceApiAssociationFactory, T1> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SourceApiAssociationFactory, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1>(this CombinedResult<T1, SourceApiAssociationFactory> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SourceApiAssociationFactory, T1, T2, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2>(this CombinedResult<SourceApiAssociationFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SourceApiAssociationFactory, T2, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2>(this CombinedResult<T1, SourceApiAssociationFactory, T2> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SourceApiAssociationFactory, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2>(this CombinedResult<T1, T2, SourceApiAssociationFactory> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SourceApiAssociationFactory, T1, T2, T3, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3>(this CombinedResult<SourceApiAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SourceApiAssociationFactory, T2, T3, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3>(this CombinedResult<T1, SourceApiAssociationFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SourceApiAssociationFactory, T3, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3>(this CombinedResult<T1, T2, SourceApiAssociationFactory, T3> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SourceApiAssociationFactory, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SourceApiAssociationFactory> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SourceApiAssociationFactory, T1, T2, T3, T4, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3, T4>(this CombinedResult<SourceApiAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SourceApiAssociationFactory, T2, T3, T4, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3, T4>(this CombinedResult<T1, SourceApiAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SourceApiAssociationFactory, T3, T4, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SourceApiAssociationFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SourceApiAssociationFactory, T4, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SourceApiAssociationFactory, T4> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SourceApiAssociationFactory, InnerSourceApiAssociationSourceApiAssociationConfigFactory> WithSourceApiAssociationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SourceApiAssociationFactory> combinedResult, Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceApiAssociationConfig(combinedResult.T5, subFactoryAction));
}
