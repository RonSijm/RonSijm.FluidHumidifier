// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRecipeDataCatalogInputDefinitionFactory(Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition>
{

    internal InnerRecipeS3LocationFactory TempDirectoryFactory { get; set; }

    protected override Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition Create()
    {
        var dataCatalogInputDefinitionResult = CreateDataCatalogInputDefinition();
        factoryAction?.Invoke(dataCatalogInputDefinitionResult);

        return dataCatalogInputDefinitionResult;
    }

    private Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition CreateDataCatalogInputDefinition()
    {
        var dataCatalogInputDefinitionResult = new Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition();

        return dataCatalogInputDefinitionResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition result)
    {
        base.CreateChildren(result);

        result.TempDirectory ??= TempDirectoryFactory?.Build();
    }

} // End Of Class

public static class InnerRecipeDataCatalogInputDefinitionFactoryExtensions
{
    public static CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, InnerRecipeS3LocationFactory> WithTempDirectory(this InnerRecipeDataCatalogInputDefinitionFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.TempDirectoryFactory = new InnerRecipeS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TempDirectoryFactory);
    }

    public static CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, InnerRecipeS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, InnerRecipeS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2, T3, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2, T3, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory, T3, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2, T3, T4, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<InnerRecipeDataCatalogInputDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2, T3, T4, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeDataCatalogInputDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory, T3, T4, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeDataCatalogInputDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory, T4, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeDataCatalogInputDefinitionFactory, InnerRecipeS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T5, subFactoryAction));
}
