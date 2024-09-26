// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageRecipeInstanceBlockDeviceMappingFactory(Action<Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping>
{

    internal InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory EbsFactory { get; set; }

    protected override Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping Create()
    {
        var instanceBlockDeviceMappingResult = CreateInstanceBlockDeviceMapping();
        factoryAction?.Invoke(instanceBlockDeviceMappingResult);

        return instanceBlockDeviceMappingResult;
    }

    private Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping CreateInstanceBlockDeviceMapping()
    {
        var instanceBlockDeviceMappingResult = new Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping();

        return instanceBlockDeviceMappingResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.ImageRecipeTypes.InstanceBlockDeviceMapping result)
    {
        base.CreateChildren(result);

        result.Ebs ??= EbsFactory?.Build();
    }

} // End Of Class

public static class InnerImageRecipeInstanceBlockDeviceMappingFactoryExtensions
{
    public static CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs(this InnerImageRecipeInstanceBlockDeviceMappingFactory parentFactory, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null)
    {
        parentFactory.EbsFactory = new InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsFactory);
    }

    public static CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1>(this CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1>(this CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2>(this CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2>(this CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2>(this CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2, T3, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3>(this CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2, T3, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory, T3, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageRecipeInstanceBlockDeviceMappingFactory, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImageRecipeInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2, T3, T4, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<InnerImageRecipeInstanceBlockDeviceMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2, T3, T4, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, InnerImageRecipeInstanceBlockDeviceMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory, T3, T4, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImageRecipeInstanceBlockDeviceMappingFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageRecipeInstanceBlockDeviceMappingFactory, T4, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImageRecipeInstanceBlockDeviceMappingFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerImageRecipeInstanceBlockDeviceMappingFactory, InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImageRecipeInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T5, subFactoryAction));
}
