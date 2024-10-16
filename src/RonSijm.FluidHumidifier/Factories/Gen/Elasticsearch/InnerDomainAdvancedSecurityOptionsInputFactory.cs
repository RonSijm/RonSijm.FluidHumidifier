// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainAdvancedSecurityOptionsInputFactory(Action<Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput>
{

    internal InnerDomainMasterUserOptionsFactory MasterUserOptionsFactory { get; set; }

    protected override Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput Create()
    {
        var advancedSecurityOptionsInputResult = CreateAdvancedSecurityOptionsInput();
        factoryAction?.Invoke(advancedSecurityOptionsInputResult);

        return advancedSecurityOptionsInputResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput CreateAdvancedSecurityOptionsInput()
    {
        var advancedSecurityOptionsInputResult = new Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput();

        return advancedSecurityOptionsInputResult;
    }
    public override void CreateChildren(Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput result)
    {
        base.CreateChildren(result);

        result.MasterUserOptions ??= MasterUserOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDomainAdvancedSecurityOptionsInputFactoryExtensions
{
    public static CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions(this InnerDomainAdvancedSecurityOptionsInputFactory parentFactory, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null)
    {
        parentFactory.MasterUserOptionsFactory = new InnerDomainMasterUserOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MasterUserOptionsFactory);
    }

    public static CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1>(this CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1>(this CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2>(this CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2>(this CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2>(this CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2, T3, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3>(this CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2, T3, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3>(this CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2, T3> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory, T3, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory, T3> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAdvancedSecurityOptionsInputFactory, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAdvancedSecurityOptionsInputFactory> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2, T3, T4, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3, T4>(this CombinedResult<InnerDomainAdvancedSecurityOptionsInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2, T3, T4, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAdvancedSecurityOptionsInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory, T3, T4, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAdvancedSecurityOptionsInputFactory, T3, T4> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAdvancedSecurityOptionsInputFactory, T4, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAdvancedSecurityOptionsInputFactory, T4> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAdvancedSecurityOptionsInputFactory, InnerDomainMasterUserOptionsFactory> WithMasterUserOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAdvancedSecurityOptionsInputFactory> combinedResult, Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMasterUserOptions(combinedResult.T5, subFactoryAction));
}
