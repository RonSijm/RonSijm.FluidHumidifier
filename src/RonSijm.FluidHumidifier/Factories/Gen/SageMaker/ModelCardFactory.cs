// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ModelCardFactory(string resourceName = null, Action<Humidifier.SageMaker.ModelCard> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ModelCard>(resourceName)
{

    internal InnerModelCardUserContextFactory LastModifiedByFactory { get; set; }

    internal InnerModelCardUserContextFactory CreatedByFactory { get; set; }

    internal InnerModelCardSecurityConfigFactory SecurityConfigFactory { get; set; }

    internal InnerModelCardContentFactory ContentFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCard Create()
    {
        var modelCardResult = CreateModelCard();
        factoryAction?.Invoke(modelCardResult);

        return modelCardResult;
    }

    private Humidifier.SageMaker.ModelCard CreateModelCard()
    {
        var modelCardResult = new Humidifier.SageMaker.ModelCard
        {
            GivenName = InputResourceName,
        };

        return modelCardResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCard result)
    {
        base.CreateChildren(result);

        result.LastModifiedBy ??= LastModifiedByFactory?.Build();
        result.CreatedBy ??= CreatedByFactory?.Build();
        result.SecurityConfig ??= SecurityConfigFactory?.Build();
        result.Content ??= ContentFactory?.Build();
    }

} // End Of Class

public static class ModelCardFactoryExtensions
{
    public static CombinedResult<ModelCardFactory, InnerModelCardUserContextFactory> WithLastModifiedBy(this ModelCardFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null)
    {
        parentFactory.LastModifiedByFactory = new InnerModelCardUserContextFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LastModifiedByFactory);
    }

    public static CombinedResult<ModelCardFactory, InnerModelCardUserContextFactory> WithCreatedBy(this ModelCardFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null)
    {
        parentFactory.CreatedByFactory = new InnerModelCardUserContextFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreatedByFactory);
    }

    public static CombinedResult<ModelCardFactory, InnerModelCardSecurityConfigFactory> WithSecurityConfig(this ModelCardFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null)
    {
        parentFactory.SecurityConfigFactory = new InnerModelCardSecurityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityConfigFactory);
    }

    public static CombinedResult<ModelCardFactory, InnerModelCardContentFactory> WithContent(this ModelCardFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerModelCardContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<ModelCardFactory, T1, InnerModelCardUserContextFactory> WithLastModifiedBy<T1>(this CombinedResult<ModelCardFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, InnerModelCardUserContextFactory> WithLastModifiedBy<T1>(this CombinedResult<T1, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2>(this CombinedResult<ModelCardFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2>(this CombinedResult<T1, ModelCardFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2>(this CombinedResult<T1, T2, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3>(this CombinedResult<ModelCardFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3>(this CombinedResult<T1, ModelCardFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3>(this CombinedResult<T1, T2, ModelCardFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, T4, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3, T4>(this CombinedResult<ModelCardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, T4, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3, T4>(this CombinedResult<T1, ModelCardFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, T4, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelCardFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, T4, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelCardFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelCardFactory, InnerModelCardUserContextFactory> WithLastModifiedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedBy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, InnerModelCardUserContextFactory> WithCreatedBy<T1>(this CombinedResult<ModelCardFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, InnerModelCardUserContextFactory> WithCreatedBy<T1>(this CombinedResult<T1, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2>(this CombinedResult<ModelCardFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, ModelCardFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, T2, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<ModelCardFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, ModelCardFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, ModelCardFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, T4, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<ModelCardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, T4, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, ModelCardFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, T4, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelCardFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, T4, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelCardFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelCardFactory, InnerModelCardUserContextFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.UserContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1>(this CombinedResult<ModelCardFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1>(this CombinedResult<T1, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<ModelCardFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<T1, ModelCardFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<T1, T2, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<ModelCardFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, ModelCardFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, ModelCardFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, T4, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<ModelCardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, T4, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, ModelCardFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, T4, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelCardFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, T4, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelCardFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelCardFactory, InnerModelCardSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.SecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, InnerModelCardContentFactory> WithContent<T1>(this CombinedResult<ModelCardFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, InnerModelCardContentFactory> WithContent<T1>(this CombinedResult<T1, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, InnerModelCardContentFactory> WithContent<T1, T2>(this CombinedResult<ModelCardFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, InnerModelCardContentFactory> WithContent<T1, T2>(this CombinedResult<T1, ModelCardFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, InnerModelCardContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, InnerModelCardContentFactory> WithContent<T1, T2, T3>(this CombinedResult<ModelCardFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, InnerModelCardContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, ModelCardFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, InnerModelCardContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, ModelCardFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, InnerModelCardContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelCardFactory, T1, T2, T3, T4, InnerModelCardContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<ModelCardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelCardFactory, T2, T3, T4, InnerModelCardContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, ModelCardFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelCardFactory, T3, T4, InnerModelCardContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelCardFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelCardFactory, T4, InnerModelCardContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelCardFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelCardFactory, InnerModelCardContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelCardFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction));
}
