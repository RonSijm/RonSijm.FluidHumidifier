// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class SpaceFactory(string resourceName = null, Action<Humidifier.SageMaker.Space> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Space>(resourceName)
{

    internal InnerSpaceSpaceSettingsFactory SpaceSettingsFactory { get; set; }

    internal InnerSpaceSpaceSharingSettingsFactory SpaceSharingSettingsFactory { get; set; }

    internal InnerSpaceOwnershipSettingsFactory OwnershipSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.Space Create()
    {
        var spaceResult = CreateSpace();
        factoryAction?.Invoke(spaceResult);

        return spaceResult;
    }

    private Humidifier.SageMaker.Space CreateSpace()
    {
        var spaceResult = new Humidifier.SageMaker.Space
        {
            GivenName = InputResourceName,
        };

        return spaceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Space result)
    {
        base.CreateChildren(result);

        result.SpaceSettings ??= SpaceSettingsFactory?.Build();
        result.SpaceSharingSettings ??= SpaceSharingSettingsFactory?.Build();
        result.OwnershipSettings ??= OwnershipSettingsFactory?.Build();
    }

} // End Of Class

public static class SpaceFactoryExtensions
{
    public static CombinedResult<SpaceFactory, InnerSpaceSpaceSettingsFactory> WithSpaceSettings(this SpaceFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null)
    {
        parentFactory.SpaceSettingsFactory = new InnerSpaceSpaceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpaceSettingsFactory);
    }

    public static CombinedResult<SpaceFactory, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings(this SpaceFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null)
    {
        parentFactory.SpaceSharingSettingsFactory = new InnerSpaceSpaceSharingSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpaceSharingSettingsFactory);
    }

    public static CombinedResult<SpaceFactory, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings(this SpaceFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null)
    {
        parentFactory.OwnershipSettingsFactory = new InnerSpaceOwnershipSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnershipSettingsFactory);
    }

    public static CombinedResult<SpaceFactory, T1, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceSpaceSettingsFactory> WithSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceSpaceSharingSettingsFactory> WithSpaceSharingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpaceSharingSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceOwnershipSettingsFactory> WithOwnershipSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.OwnershipSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwnershipSettings(combinedResult.T5, subFactoryAction));
}
