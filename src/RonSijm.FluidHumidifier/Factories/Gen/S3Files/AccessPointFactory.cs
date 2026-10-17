// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class AccessPointFactory(string resourceName = null, Action<Humidifier.S3Files.AccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3Files.AccessPoint>(resourceName)
{

    internal List<InnerAccessPointAccessPointTagFactory> TagsFactories { get; set; } = [];

    internal InnerAccessPointRootDirectoryFactory RootDirectoryFactory { get; set; }

    internal InnerAccessPointPosixUserFactory PosixUserFactory { get; set; }

    protected override Humidifier.S3Files.AccessPoint Create()
    {
        var accessPointResult = CreateAccessPoint();
        factoryAction?.Invoke(accessPointResult);

        return accessPointResult;
    }

    private Humidifier.S3Files.AccessPoint CreateAccessPoint()
    {
        var accessPointResult = new Humidifier.S3Files.AccessPoint
        {
            GivenName = InputResourceName,
        };

        return accessPointResult;
    }
    public override void CreateChildren(Humidifier.S3Files.AccessPoint result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.RootDirectory ??= RootDirectoryFactory?.Build();
        result.PosixUser ??= PosixUserFactory?.Build();
    }

} // End Of Class

public static class AccessPointFactoryExtensions
{
    public static CombinedResult<AccessPointFactory, InnerAccessPointAccessPointTagFactory> WithTags(this AccessPointFactory parentFactory, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null)
    {
        var factory = new InnerAccessPointAccessPointTagFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AccessPointFactory, InnerAccessPointRootDirectoryFactory> WithRootDirectory(this AccessPointFactory parentFactory, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null)
    {
        parentFactory.RootDirectoryFactory = new InnerAccessPointRootDirectoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RootDirectoryFactory);
    }

    public static CombinedResult<AccessPointFactory, InnerAccessPointPosixUserFactory> WithPosixUser(this AccessPointFactory parentFactory, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null)
    {
        parentFactory.PosixUserFactory = new InnerAccessPointPosixUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PosixUserFactory);
    }

    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointAccessPointTagFactory> WithTags<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointAccessPointTagFactory> WithTags<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointAccessPointTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, WithRootDirectory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, WithRootDirectory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointRootDirectoryFactory> WithRootDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootDirectory(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointPosixUserFactory> WithPosixUser<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointPosixUserFactory> WithPosixUser<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointPosixUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T5, subFactoryAction).T2);
}
