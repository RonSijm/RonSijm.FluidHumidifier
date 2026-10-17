// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupGateway;

public class GatewayFactory(string resourceName = null, Action<Humidifier.BackupGateway.Gateway> factoryAction = null) : ResourceFactory<Humidifier.BackupGateway.Gateway>(resourceName)
{

    internal List<InnerGatewayTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.BackupGateway.Gateway Create()
    {
        var gatewayResult = CreateGateway();
        factoryAction?.Invoke(gatewayResult);

        return gatewayResult;
    }

    private Humidifier.BackupGateway.Gateway CreateGateway()
    {
        var gatewayResult = new Humidifier.BackupGateway.Gateway
        {
            GivenName = InputResourceName,
        };

        return gatewayResult;
    }
    public override void CreateChildren(Humidifier.BackupGateway.Gateway result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GatewayFactoryExtensions
{
    public static CombinedResult<GatewayFactory, InnerGatewayTagsItemsFactory> WithTags(this GatewayFactory parentFactory, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerGatewayTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayFactory, T1, InnerGatewayTagsItemsFactory> WithTags<T1>(this CombinedResult<GatewayFactory, T1> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, InnerGatewayTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, GatewayFactory> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, InnerGatewayTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<GatewayFactory, T1, T2> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, InnerGatewayTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, GatewayFactory, T2> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, InnerGatewayTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, GatewayFactory> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, T3, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<GatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, T3, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, GatewayFactory, T2, T3> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, T3, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, GatewayFactory, T3> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayFactory, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayFactory> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, T3, T4, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<GatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, T3, T4, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, GatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, T3, T4, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayFactory, T3, T4> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayFactory, T4, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayFactory, T4> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GatewayFactory, InnerGatewayTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayFactory> combinedResult, Action<Humidifier.BackupGateway.GatewayTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
