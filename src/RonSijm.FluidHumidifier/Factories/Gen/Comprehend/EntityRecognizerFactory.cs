// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class EntityRecognizerFactory(string resourceName = null, Action<Humidifier.Comprehend.EntityRecognizer> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.EntityRecognizer>(resourceName)
{

    internal InnerEntityRecognizerVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerEntityRecognizerEntityRecognizerInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.EntityRecognizer Create()
    {
        var entityRecognizerResult = CreateEntityRecognizer();
        factoryAction?.Invoke(entityRecognizerResult);

        return entityRecognizerResult;
    }

    private Humidifier.Comprehend.EntityRecognizer CreateEntityRecognizer()
    {
        var entityRecognizerResult = new Humidifier.Comprehend.EntityRecognizer
        {
            GivenName = InputResourceName,
        };

        return entityRecognizerResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.EntityRecognizer result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class EntityRecognizerFactoryExtensions
{
    public static CombinedResult<EntityRecognizerFactory, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig(this EntityRecognizerFactory parentFactory, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerEntityRecognizerVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<EntityRecognizerFactory, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig(this EntityRecognizerFactory parentFactory, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerEntityRecognizerEntityRecognizerInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<EntityRecognizerFactory, T1, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<EntityRecognizerFactory, T1> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<EntityRecognizerFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, EntityRecognizerFactory, T2> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, T3, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<EntityRecognizerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, T3, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, EntityRecognizerFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, T3, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, EntityRecognizerFactory, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntityRecognizerFactory, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, T3, T4, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<EntityRecognizerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, T3, T4, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, EntityRecognizerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, T3, T4, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EntityRecognizerFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntityRecognizerFactory, T4, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EntityRecognizerFactory, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EntityRecognizerFactory, InnerEntityRecognizerVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<EntityRecognizerFactory, T1> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<EntityRecognizerFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, EntityRecognizerFactory, T2> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, T3, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<EntityRecognizerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, T3, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, EntityRecognizerFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, T3, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, EntityRecognizerFactory, T3> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntityRecognizerFactory, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EntityRecognizerFactory, T1, T2, T3, T4, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<EntityRecognizerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntityRecognizerFactory, T2, T3, T4, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, EntityRecognizerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntityRecognizerFactory, T3, T4, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EntityRecognizerFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntityRecognizerFactory, T4, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EntityRecognizerFactory, T4> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EntityRecognizerFactory, InnerEntityRecognizerEntityRecognizerInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EntityRecognizerFactory> combinedResult, Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
