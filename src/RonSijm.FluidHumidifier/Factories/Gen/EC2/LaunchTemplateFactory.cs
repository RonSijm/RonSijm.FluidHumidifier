// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LaunchTemplateFactory(string resourceName = null, Action<Humidifier.EC2.LaunchTemplate> factoryAction = null) : ResourceFactory<Humidifier.EC2.LaunchTemplate>(resourceName)
{

    internal List<InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> TagSpecificationsFactories { get; set; } = [];

    internal InnerLaunchTemplateLaunchTemplateDataFactory LaunchTemplateDataFactory { get; set; }

    protected override Humidifier.EC2.LaunchTemplate Create()
    {
        var launchTemplateResult = CreateLaunchTemplate();
        factoryAction?.Invoke(launchTemplateResult);

        return launchTemplateResult;
    }

    private Humidifier.EC2.LaunchTemplate CreateLaunchTemplate()
    {
        var launchTemplateResult = new Humidifier.EC2.LaunchTemplate
        {
            GivenName = InputResourceName,
        };

        return launchTemplateResult;
    }
    public override void CreateChildren(Humidifier.EC2.LaunchTemplate result)
    {
        base.CreateChildren(result);

        result.TagSpecifications = TagSpecificationsFactories.Any() ? TagSpecificationsFactories.Select(x => x.Build()).ToList() : null;
        result.LaunchTemplateData ??= LaunchTemplateDataFactory?.Build();
    }

} // End Of Class

public static class LaunchTemplateFactoryExtensions
{
    public static CombinedResult<LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications(this LaunchTemplateFactory parentFactory, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null)
    {
        var factory = new InnerLaunchTemplateLaunchTemplateTagSpecificationFactory(subFactoryAction);
        parentFactory.TagSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData(this LaunchTemplateFactory parentFactory, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null)
    {
        parentFactory.LaunchTemplateDataFactory = new InnerLaunchTemplateLaunchTemplateDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchTemplateDataFactory);
    }

    public static CombinedResult<LaunchTemplateFactory, T1, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<LaunchTemplateFactory, T1> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<T1, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<LaunchTemplateFactory, T1, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, LaunchTemplateFactory, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, T2, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, T3, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<LaunchTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, T3, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, LaunchTemplateFactory, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, T3, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, LaunchTemplateFactory, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, T3, T4, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<LaunchTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, T3, T4, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, LaunchTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, T3, T4, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchTemplateFactory, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchTemplateFactory, T4, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchTemplateFactory, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1>(this CombinedResult<LaunchTemplateFactory, T1> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1>(this CombinedResult<T1, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2>(this CombinedResult<LaunchTemplateFactory, T1, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2>(this CombinedResult<T1, LaunchTemplateFactory, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2>(this CombinedResult<T1, T2, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, T3, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3>(this CombinedResult<LaunchTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, T3, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3>(this CombinedResult<T1, LaunchTemplateFactory, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, T3, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3>(this CombinedResult<T1, T2, LaunchTemplateFactory, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LaunchTemplateFactory, T1, T2, T3, T4, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3, T4>(this CombinedResult<LaunchTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchTemplateFactory, T2, T3, T4, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, LaunchTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchTemplateFactory, T3, T4, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchTemplateFactory, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchTemplateFactory, T4, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchTemplateFactory, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LaunchTemplateFactory, InnerLaunchTemplateLaunchTemplateDataFactory> WithLaunchTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchTemplateFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateData(combinedResult.T5, subFactoryAction));
}
