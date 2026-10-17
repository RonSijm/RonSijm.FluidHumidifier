// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class ImportedModelFactory(string resourceName = null, Action<Humidifier.Bedrock.ImportedModel> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.ImportedModel>(resourceName)
{

    internal InnerImportedModelModelDataSourceFactory ModelDataSourceFactory { get; set; }

    protected override Humidifier.Bedrock.ImportedModel Create()
    {
        var importedModelResult = CreateImportedModel();
        factoryAction?.Invoke(importedModelResult);

        return importedModelResult;
    }

    private Humidifier.Bedrock.ImportedModel CreateImportedModel()
    {
        var importedModelResult = new Humidifier.Bedrock.ImportedModel
        {
            GivenName = InputResourceName,
        };

        return importedModelResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.ImportedModel result)
    {
        base.CreateChildren(result);

        result.ModelDataSource ??= ModelDataSourceFactory?.Build();
    }

} // End Of Class

public static class ImportedModelFactoryExtensions
{
    public static CombinedResult<ImportedModelFactory, InnerImportedModelModelDataSourceFactory> WithModelDataSource(this ImportedModelFactory parentFactory, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null)
    {
        parentFactory.ModelDataSourceFactory = new InnerImportedModelModelDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelDataSourceFactory);
    }

    public static CombinedResult<ImportedModelFactory, T1, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1>(this CombinedResult<ImportedModelFactory, T1> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportedModelFactory, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1>(this CombinedResult<T1, ImportedModelFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ImportedModelFactory, T1, T2, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<ImportedModelFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportedModelFactory, T2, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<T1, ImportedModelFactory, T2> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportedModelFactory, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<T1, T2, ImportedModelFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ImportedModelFactory, T1, T2, T3, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<ImportedModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportedModelFactory, T2, T3, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, ImportedModelFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportedModelFactory, T3, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, T2, ImportedModelFactory, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportedModelFactory, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImportedModelFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ImportedModelFactory, T1, T2, T3, T4, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<ImportedModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportedModelFactory, T2, T3, T4, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, ImportedModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportedModelFactory, T3, T4, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImportedModelFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportedModelFactory, T4, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImportedModelFactory, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ImportedModelFactory, InnerImportedModelModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImportedModelFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T5, subFactoryAction).T2);
}
