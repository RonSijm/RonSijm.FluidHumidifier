// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ImageUsageReportFactory(string resourceName = null, Action<Humidifier.EC2.ImageUsageReport> factoryAction = null) : ResourceFactory<Humidifier.EC2.ImageUsageReport>(resourceName)
{

    internal List<InnerImageUsageReportImageUsageResourceTypeFactory> ResourceTypesFactories { get; set; } = [];

    protected override Humidifier.EC2.ImageUsageReport Create()
    {
        var imageUsageReportResult = CreateImageUsageReport();
        factoryAction?.Invoke(imageUsageReportResult);

        return imageUsageReportResult;
    }

    private Humidifier.EC2.ImageUsageReport CreateImageUsageReport()
    {
        var imageUsageReportResult = new Humidifier.EC2.ImageUsageReport
        {
            GivenName = InputResourceName,
        };

        return imageUsageReportResult;
    }
    public override void CreateChildren(Humidifier.EC2.ImageUsageReport result)
    {
        base.CreateChildren(result);

        result.ResourceTypes = ResourceTypesFactories.Any() ? ResourceTypesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ImageUsageReportFactoryExtensions
{
    public static CombinedResult<ImageUsageReportFactory, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes(this ImageUsageReportFactory parentFactory, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null)
    {
        var factory = new InnerImageUsageReportImageUsageResourceTypeFactory(subFactoryAction);
        parentFactory.ResourceTypesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ImageUsageReportFactory, T1, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1>(this CombinedResult<ImageUsageReportFactory, T1> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTypes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImageUsageReportFactory, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1>(this CombinedResult<T1, ImageUsageReportFactory> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTypes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ImageUsageReportFactory, T1, T2, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2>(this CombinedResult<ImageUsageReportFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImageUsageReportFactory, T2, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2>(this CombinedResult<T1, ImageUsageReportFactory, T2> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImageUsageReportFactory, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2>(this CombinedResult<T1, T2, ImageUsageReportFactory> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ImageUsageReportFactory, T1, T2, T3, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3>(this CombinedResult<ImageUsageReportFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImageUsageReportFactory, T2, T3, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3>(this CombinedResult<T1, ImageUsageReportFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImageUsageReportFactory, T3, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3>(this CombinedResult<T1, T2, ImageUsageReportFactory, T3> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImageUsageReportFactory, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageUsageReportFactory> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ImageUsageReportFactory, T1, T2, T3, T4, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3, T4>(this CombinedResult<ImageUsageReportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImageUsageReportFactory, T2, T3, T4, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3, T4>(this CombinedResult<T1, ImageUsageReportFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImageUsageReportFactory, T3, T4, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageUsageReportFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImageUsageReportFactory, T4, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageUsageReportFactory, T4> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ImageUsageReportFactory, InnerImageUsageReportImageUsageResourceTypeFactory> WithResourceTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageUsageReportFactory> combinedResult, Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTypes(combinedResult.T5, subFactoryAction).T2);
}
