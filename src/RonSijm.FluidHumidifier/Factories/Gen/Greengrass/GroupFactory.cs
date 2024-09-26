// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class GroupFactory(string resourceName = null, Action<Humidifier.Greengrass.Group> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.Group>(resourceName)
{

    internal InnerGroupGroupVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.Greengrass.Group CreateGroup()
    {
        var groupResult = new Humidifier.Greengrass.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.Group result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class GroupFactoryExtensions
{
    public static CombinedResult<GroupFactory, InnerGroupGroupVersionFactory> WithInitialVersion(this GroupFactory parentFactory, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerGroupGroupVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<GroupFactory, T1, InnerGroupGroupVersionFactory> WithInitialVersion<T1>(this CombinedResult<GroupFactory, T1> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, InnerGroupGroupVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, GroupFactory> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<GroupFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, GroupFactory, T2> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, GroupFactory> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<GroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, GroupFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, GroupFactory, T3> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupFactory> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, T4, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<GroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, T4, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, GroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, T4, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, T4, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupFactory, T4> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupFactory, InnerGroupGroupVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupFactory> combinedResult, Action<Humidifier.Greengrass.GroupTypes.GroupVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
