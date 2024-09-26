// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardModelPackageDetailsFactory(Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails>
{

    internal InnerModelCardModelPackageCreatorFactory CreatedByFactory { get; set; }

    internal InnerModelCardInferenceSpecificationFactory InferenceSpecificationFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails Create()
    {
        var modelPackageDetailsResult = CreateModelPackageDetails();
        factoryAction?.Invoke(modelPackageDetailsResult);

        return modelPackageDetailsResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails CreateModelPackageDetails()
    {
        var modelPackageDetailsResult = new Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails();

        return modelPackageDetailsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardTypes.ModelPackageDetails result)
    {
        base.CreateChildren(result);

        result.CreatedBy ??= CreatedByFactory?.Build();
        result.InferenceSpecification ??= InferenceSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerModelCardModelPackageDetailsFactoryExtensions
{
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, InnerModelCardModelPackageCreatorFactory> WithCreatedBy(this InnerModelCardModelPackageDetailsFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null)
    {
        parentFactory.CreatedByFactory = new InnerModelCardModelPackageCreatorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreatedByFactory);
    }

    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification(this InnerModelCardModelPackageDetailsFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null)
    {
        parentFactory.InferenceSpecificationFactory = new InnerModelCardInferenceSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceSpecificationFactory);
    }

    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, T4, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, T4, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, T4, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, T4, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardModelPackageDetailsFactory, InnerModelCardModelPackageCreatorFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ModelPackageCreator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, T4, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<InnerModelCardModelPackageDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, T4, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardModelPackageDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, T4, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardModelPackageDetailsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, T4, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardModelPackageDetailsFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardModelPackageDetailsFactory, InnerModelCardInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardModelPackageDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T5, subFactoryAction));
}
