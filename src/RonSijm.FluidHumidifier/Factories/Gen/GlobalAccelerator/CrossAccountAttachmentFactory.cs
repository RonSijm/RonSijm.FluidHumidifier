// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class CrossAccountAttachmentFactory(string resourceName = null, Action<Humidifier.GlobalAccelerator.CrossAccountAttachment> factoryAction = null) : ResourceFactory<Humidifier.GlobalAccelerator.CrossAccountAttachment>(resourceName)
{

    internal List<InnerCrossAccountAttachmentResourceFactory> ResourcesFactories { get; set; } = [];

    protected override Humidifier.GlobalAccelerator.CrossAccountAttachment Create()
    {
        var crossAccountAttachmentResult = CreateCrossAccountAttachment();
        factoryAction?.Invoke(crossAccountAttachmentResult);

        return crossAccountAttachmentResult;
    }

    private Humidifier.GlobalAccelerator.CrossAccountAttachment CreateCrossAccountAttachment()
    {
        var crossAccountAttachmentResult = new Humidifier.GlobalAccelerator.CrossAccountAttachment
        {
            GivenName = InputResourceName,
        };

        return crossAccountAttachmentResult;
    }
    public override void CreateChildren(Humidifier.GlobalAccelerator.CrossAccountAttachment result)
    {
        base.CreateChildren(result);

        result.Resources = ResourcesFactories.Any() ? ResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CrossAccountAttachmentFactoryExtensions
{
    public static CombinedResult<CrossAccountAttachmentFactory, InnerCrossAccountAttachmentResourceFactory> WithResources(this CrossAccountAttachmentFactory parentFactory, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null)
    {
        var factory = new InnerCrossAccountAttachmentResourceFactory(subFactoryAction);
        parentFactory.ResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CrossAccountAttachmentFactory, T1, InnerCrossAccountAttachmentResourceFactory> WithResources<T1>(this CombinedResult<CrossAccountAttachmentFactory, T1> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CrossAccountAttachmentFactory, InnerCrossAccountAttachmentResourceFactory> WithResources<T1>(this CombinedResult<T1, CrossAccountAttachmentFactory> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CrossAccountAttachmentFactory, T1, T2, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2>(this CombinedResult<CrossAccountAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CrossAccountAttachmentFactory, T2, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, CrossAccountAttachmentFactory, T2> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CrossAccountAttachmentFactory, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, CrossAccountAttachmentFactory> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CrossAccountAttachmentFactory, T1, T2, T3, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<CrossAccountAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CrossAccountAttachmentFactory, T2, T3, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, CrossAccountAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CrossAccountAttachmentFactory, T3, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, CrossAccountAttachmentFactory, T3> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CrossAccountAttachmentFactory, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, CrossAccountAttachmentFactory> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CrossAccountAttachmentFactory, T1, T2, T3, T4, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<CrossAccountAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CrossAccountAttachmentFactory, T2, T3, T4, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, CrossAccountAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CrossAccountAttachmentFactory, T3, T4, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, CrossAccountAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CrossAccountAttachmentFactory, T4, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CrossAccountAttachmentFactory, T4> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CrossAccountAttachmentFactory, InnerCrossAccountAttachmentResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CrossAccountAttachmentFactory> combinedResult, Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction));
}
