// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class IdentityFactory(string resourceName = null, Action<Humidifier.PinpointEmail.Identity> factoryAction = null) : ResourceFactory<Humidifier.PinpointEmail.Identity>(resourceName)
{

    internal List<InnerIdentityTagsFactory> TagsFactories { get; set; } = [];

    internal InnerIdentityMailFromAttributesFactory MailFromAttributesFactory { get; set; }

    protected override Humidifier.PinpointEmail.Identity Create()
    {
        var identityResult = CreateIdentity();
        factoryAction?.Invoke(identityResult);

        return identityResult;
    }

    private Humidifier.PinpointEmail.Identity CreateIdentity()
    {
        var identityResult = new Humidifier.PinpointEmail.Identity
        {
            GivenName = InputResourceName,
        };

        return identityResult;
    }
    public override void CreateChildren(Humidifier.PinpointEmail.Identity result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.MailFromAttributes ??= MailFromAttributesFactory?.Build();
    }

} // End Of Class

public static class IdentityFactoryExtensions
{
    public static CombinedResult<IdentityFactory, InnerIdentityTagsFactory> WithTags(this IdentityFactory parentFactory, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerIdentityTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdentityFactory, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes(this IdentityFactory parentFactory, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null)
    {
        parentFactory.MailFromAttributesFactory = new InnerIdentityMailFromAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MailFromAttributesFactory);
    }

    public static CombinedResult<IdentityFactory, T1, InnerIdentityTagsFactory> WithTags<T1>(this CombinedResult<IdentityFactory, T1> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, InnerIdentityTagsFactory> WithTags<T1>(this CombinedResult<T1, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, InnerIdentityTagsFactory> WithTags<T1, T2>(this CombinedResult<IdentityFactory, T1, T2> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, InnerIdentityTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, IdentityFactory, T2> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, InnerIdentityTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, T3, InnerIdentityTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<IdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, T3, InnerIdentityTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, IdentityFactory, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, T3, InnerIdentityTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, IdentityFactory, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityFactory, InnerIdentityTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, T3, T4, InnerIdentityTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<IdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, T3, T4, InnerIdentityTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, IdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, T3, T4, InnerIdentityTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityFactory, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityFactory, T4, InnerIdentityTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityFactory, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityFactory, InnerIdentityTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1>(this CombinedResult<IdentityFactory, T1> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1>(this CombinedResult<T1, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2>(this CombinedResult<IdentityFactory, T1, T2> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2>(this CombinedResult<T1, IdentityFactory, T2> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2>(this CombinedResult<T1, T2, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, T3, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3>(this CombinedResult<IdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, T3, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3>(this CombinedResult<T1, IdentityFactory, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, T3, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3>(this CombinedResult<T1, T2, IdentityFactory, T3> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityFactory, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityFactory, T1, T2, T3, T4, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3, T4>(this CombinedResult<IdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityFactory, T2, T3, T4, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3, T4>(this CombinedResult<T1, IdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityFactory, T3, T4, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityFactory, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityFactory, T4, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityFactory, T4> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityFactory, InnerIdentityMailFromAttributesFactory> WithMailFromAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityFactory> combinedResult, Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMailFromAttributes(combinedResult.T5, subFactoryAction));
}
