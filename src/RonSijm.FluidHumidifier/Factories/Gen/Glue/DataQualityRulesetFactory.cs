// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class DataQualityRulesetFactory(string resourceName = null, Action<Humidifier.Glue.DataQualityRuleset> factoryAction = null) : ResourceFactory<Humidifier.Glue.DataQualityRuleset>(resourceName)
{

    internal InnerDataQualityRulesetDataQualityTargetTableFactory TargetTableFactory { get; set; }

    protected override Humidifier.Glue.DataQualityRuleset Create()
    {
        var dataQualityRulesetResult = CreateDataQualityRuleset();
        factoryAction?.Invoke(dataQualityRulesetResult);

        return dataQualityRulesetResult;
    }

    private Humidifier.Glue.DataQualityRuleset CreateDataQualityRuleset()
    {
        var dataQualityRulesetResult = new Humidifier.Glue.DataQualityRuleset
        {
            GivenName = InputResourceName,
        };

        return dataQualityRulesetResult;
    }
    public override void CreateChildren(Humidifier.Glue.DataQualityRuleset result)
    {
        base.CreateChildren(result);

        result.TargetTable ??= TargetTableFactory?.Build();
    }

} // End Of Class

public static class DataQualityRulesetFactoryExtensions
{
    public static CombinedResult<DataQualityRulesetFactory, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable(this DataQualityRulesetFactory parentFactory, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null)
    {
        parentFactory.TargetTableFactory = new InnerDataQualityRulesetDataQualityTargetTableFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetTableFactory);
    }

    public static CombinedResult<DataQualityRulesetFactory, T1, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1>(this CombinedResult<DataQualityRulesetFactory, T1> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataQualityRulesetFactory, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1>(this CombinedResult<T1, DataQualityRulesetFactory> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataQualityRulesetFactory, T1, T2, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2>(this CombinedResult<DataQualityRulesetFactory, T1, T2> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataQualityRulesetFactory, T2, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2>(this CombinedResult<T1, DataQualityRulesetFactory, T2> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataQualityRulesetFactory, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2>(this CombinedResult<T1, T2, DataQualityRulesetFactory> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataQualityRulesetFactory, T1, T2, T3, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<DataQualityRulesetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataQualityRulesetFactory, T2, T3, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, DataQualityRulesetFactory, T2, T3> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataQualityRulesetFactory, T3, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, T2, DataQualityRulesetFactory, T3> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataQualityRulesetFactory, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataQualityRulesetFactory> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataQualityRulesetFactory, T1, T2, T3, T4, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<DataQualityRulesetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataQualityRulesetFactory, T2, T3, T4, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, DataQualityRulesetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataQualityRulesetFactory, T3, T4, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataQualityRulesetFactory, T3, T4> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataQualityRulesetFactory, T4, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataQualityRulesetFactory, T4> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataQualityRulesetFactory, InnerDataQualityRulesetDataQualityTargetTableFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataQualityRulesetFactory> combinedResult, Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T5, subFactoryAction));
}
