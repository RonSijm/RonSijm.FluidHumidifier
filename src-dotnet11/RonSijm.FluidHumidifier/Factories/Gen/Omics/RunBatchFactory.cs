// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class RunBatchFactory(string resourceName = null, Action<Humidifier.Omics.RunBatch> factoryAction = null) : ResourceFactory<Humidifier.Omics.RunBatch>(resourceName)
{

    internal InnerRunBatchDefaultRunSettingFactory DefaultRunSettingFactory { get; set; }

    protected override Humidifier.Omics.RunBatch Create()
    {
        var runBatchResult = CreateRunBatch();
        factoryAction?.Invoke(runBatchResult);

        return runBatchResult;
    }

    private Humidifier.Omics.RunBatch CreateRunBatch()
    {
        var runBatchResult = new Humidifier.Omics.RunBatch
        {
            GivenName = InputResourceName,
        };

        return runBatchResult;
    }
    public override void CreateChildren(Humidifier.Omics.RunBatch result)
    {
        base.CreateChildren(result);

        result.DefaultRunSetting ??= DefaultRunSettingFactory?.Build();
    }

} // End Of Class

public static class RunBatchFactoryExtensions
{
    public static CombinedResult<RunBatchFactory, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting(this RunBatchFactory parentFactory, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null)
    {
        parentFactory.DefaultRunSettingFactory = new InnerRunBatchDefaultRunSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultRunSettingFactory);
    }

    public static CombinedResult<RunBatchFactory, T1, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1>(this CombinedResult<RunBatchFactory, T1> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RunBatchFactory, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1>(this CombinedResult<T1, RunBatchFactory> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RunBatchFactory, T1, T2, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2>(this CombinedResult<RunBatchFactory, T1, T2> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RunBatchFactory, T2, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2>(this CombinedResult<T1, RunBatchFactory, T2> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RunBatchFactory, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2>(this CombinedResult<T1, T2, RunBatchFactory> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RunBatchFactory, T1, T2, T3, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3>(this CombinedResult<RunBatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RunBatchFactory, T2, T3, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3>(this CombinedResult<T1, RunBatchFactory, T2, T3> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RunBatchFactory, T3, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3>(this CombinedResult<T1, T2, RunBatchFactory, T3> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RunBatchFactory, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, RunBatchFactory> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RunBatchFactory, T1, T2, T3, T4, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3, T4>(this CombinedResult<RunBatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RunBatchFactory, T2, T3, T4, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3, T4>(this CombinedResult<T1, RunBatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RunBatchFactory, T3, T4, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, RunBatchFactory, T3, T4> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RunBatchFactory, T4, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RunBatchFactory, T4> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RunBatchFactory, InnerRunBatchDefaultRunSettingFactory> WithDefaultRunSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RunBatchFactory> combinedResult, Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRunSetting(combinedResult.T5, subFactoryAction).T2);
}
