// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRecipeInputFactory(Action<Humidifier.DataBrew.RecipeTypes.Input> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RecipeTypes.Input>
{

    internal InnerRecipeS3LocationFactory S3InputDefinitionFactory { get; set; }

    internal InnerRecipeDataCatalogInputDefinitionFactory DataCatalogInputDefinitionFactory { get; set; }

    protected override Humidifier.DataBrew.RecipeTypes.Input Create()
    {
        var inputResult = CreateInput();
        factoryAction?.Invoke(inputResult);

        return inputResult;
    }

    private Humidifier.DataBrew.RecipeTypes.Input CreateInput()
    {
        var inputResult = new Humidifier.DataBrew.RecipeTypes.Input();

        return inputResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RecipeTypes.Input result)
    {
        base.CreateChildren(result);

        result.S3InputDefinition ??= S3InputDefinitionFactory?.Build();
        result.DataCatalogInputDefinition ??= DataCatalogInputDefinitionFactory?.Build();
    }

} // End Of Class

public static class InnerRecipeInputFactoryExtensions
{
    public static CombinedResult<InnerRecipeInputFactory, InnerRecipeS3LocationFactory> WithS3InputDefinition(this InnerRecipeInputFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3InputDefinitionFactory = new InnerRecipeS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3InputDefinitionFactory);
    }

    public static CombinedResult<InnerRecipeInputFactory, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition(this InnerRecipeInputFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null)
    {
        parentFactory.DataCatalogInputDefinitionFactory = new InnerRecipeDataCatalogInputDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataCatalogInputDefinitionFactory);
    }

    public static CombinedResult<InnerRecipeInputFactory, T1, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1>(this CombinedResult<InnerRecipeInputFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1>(this CombinedResult<T1, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2>(this CombinedResult<InnerRecipeInputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2>(this CombinedResult<T1, InnerRecipeInputFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2>(this CombinedResult<T1, T2, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, T3, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3>(this CombinedResult<InnerRecipeInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, T3, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3>(this CombinedResult<T1, InnerRecipeInputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, T3, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeInputFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeInputFactory, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, T3, T4, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3, T4>(this CombinedResult<InnerRecipeInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, T3, T4, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, T3, T4, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeInputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeInputFactory, T4, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeInputFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeInputFactory, InnerRecipeS3LocationFactory> WithS3InputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputDefinition(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1>(this CombinedResult<InnerRecipeInputFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1>(this CombinedResult<T1, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2>(this CombinedResult<InnerRecipeInputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2>(this CombinedResult<T1, InnerRecipeInputFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2>(this CombinedResult<T1, T2, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3>(this CombinedResult<InnerRecipeInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, T3, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3>(this CombinedResult<T1, InnerRecipeInputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, T3, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeInputFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeInputFactory, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeInputFactory, T1, T2, T3, T4, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3, T4>(this CombinedResult<InnerRecipeInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeInputFactory, T2, T3, T4, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeInputFactory, T3, T4, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeInputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeInputFactory, T4, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeInputFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeInputFactory, InnerRecipeDataCatalogInputDefinitionFactory> WithDataCatalogInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeInputFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.DataCatalogInputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogInputDefinition(combinedResult.T5, subFactoryAction));
}
