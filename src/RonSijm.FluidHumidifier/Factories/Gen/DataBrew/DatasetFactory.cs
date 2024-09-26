// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class DatasetFactory(string resourceName = null, Action<Humidifier.DataBrew.Dataset> factoryAction = null) : ResourceFactory<Humidifier.DataBrew.Dataset>(resourceName)
{

    internal InnerDatasetInputFactory InputFactory { get; set; }

    internal InnerDatasetFormatOptionsFactory FormatOptionsFactory { get; set; }

    internal InnerDatasetPathOptionsFactory PathOptionsFactory { get; set; }

    protected override Humidifier.DataBrew.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.DataBrew.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.DataBrew.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.Dataset result)
    {
        base.CreateChildren(result);

        result.Input ??= InputFactory?.Build();
        result.FormatOptions ??= FormatOptionsFactory?.Build();
        result.PathOptions ??= PathOptionsFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetInputFactory> WithInput(this DatasetFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null)
    {
        parentFactory.InputFactory = new InnerDatasetInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputFactory);
    }

    public static CombinedResult<DatasetFactory, InnerDatasetFormatOptionsFactory> WithFormatOptions(this DatasetFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null)
    {
        parentFactory.FormatOptionsFactory = new InnerDatasetFormatOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatOptionsFactory);
    }

    public static CombinedResult<DatasetFactory, InnerDatasetPathOptionsFactory> WithPathOptions(this DatasetFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null)
    {
        parentFactory.PathOptionsFactory = new InnerDatasetPathOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PathOptionsFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetInputFactory> WithInput<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetInputFactory> WithInput<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetInputFactory> WithInput<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetInputFactory> WithInput<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetInputFactory> WithInput<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetInputFactory> WithInput<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, InnerDatasetPathOptionsFactory> WithPathOptions<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPathOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetPathOptionsFactory> WithPathOptions<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPathOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetPathOptionsFactory> WithPathOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.PathOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathOptions(combinedResult.T5, subFactoryAction));
}
