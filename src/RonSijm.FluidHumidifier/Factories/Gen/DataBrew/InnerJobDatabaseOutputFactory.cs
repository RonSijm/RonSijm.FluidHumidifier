// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobDatabaseOutputFactory(Action<Humidifier.DataBrew.JobTypes.DatabaseOutput> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.DatabaseOutput>
{

    internal InnerJobDatabaseTableOutputOptionsFactory DatabaseOptionsFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.DatabaseOutput Create()
    {
        var databaseOutputResult = CreateDatabaseOutput();
        factoryAction?.Invoke(databaseOutputResult);

        return databaseOutputResult;
    }

    private Humidifier.DataBrew.JobTypes.DatabaseOutput CreateDatabaseOutput()
    {
        var databaseOutputResult = new Humidifier.DataBrew.JobTypes.DatabaseOutput();

        return databaseOutputResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.DatabaseOutput result)
    {
        base.CreateChildren(result);

        result.DatabaseOptions ??= DatabaseOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerJobDatabaseOutputFactoryExtensions
{
    public static CombinedResult<InnerJobDatabaseOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions(this InnerJobDatabaseOutputFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null)
    {
        parentFactory.DatabaseOptionsFactory = new InnerJobDatabaseTableOutputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatabaseOptionsFactory);
    }

    public static CombinedResult<InnerJobDatabaseOutputFactory, T1, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1>(this CombinedResult<InnerJobDatabaseOutputFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1>(this CombinedResult<T1, InnerJobDatabaseOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseOutputFactory, T1, T2, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<InnerJobDatabaseOutputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseOutputFactory, T2, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<T1, InnerJobDatabaseOutputFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<T1, T2, InnerJobDatabaseOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseOutputFactory, T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<InnerJobDatabaseOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseOutputFactory, T2, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, InnerJobDatabaseOutputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseOutputFactory, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDatabaseOutputFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDatabaseOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDatabaseOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseOutputFactory, T1, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<InnerJobDatabaseOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseOutputFactory, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDatabaseOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseOutputFactory, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDatabaseOutputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDatabaseOutputFactory, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDatabaseOutputFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDatabaseOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDatabaseOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T5, subFactoryAction));
}
