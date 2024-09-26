// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class TemplateGroupAccessControlEntryFactory(string resourceName = null, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry>(resourceName)
{

    internal InnerTemplateGroupAccessControlEntryAccessRightsFactory AccessRightsFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry Create()
    {
        var templateGroupAccessControlEntryResult = CreateTemplateGroupAccessControlEntry();
        factoryAction?.Invoke(templateGroupAccessControlEntryResult);

        return templateGroupAccessControlEntryResult;
    }

    private Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry CreateTemplateGroupAccessControlEntry()
    {
        var templateGroupAccessControlEntryResult = new Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry
        {
            GivenName = InputResourceName,
        };

        return templateGroupAccessControlEntryResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntry result)
    {
        base.CreateChildren(result);

        result.AccessRights ??= AccessRightsFactory?.Build();
    }

} // End Of Class

public static class TemplateGroupAccessControlEntryFactoryExtensions
{
    public static CombinedResult<TemplateGroupAccessControlEntryFactory, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights(this TemplateGroupAccessControlEntryFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null)
    {
        parentFactory.AccessRightsFactory = new InnerTemplateGroupAccessControlEntryAccessRightsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessRightsFactory);
    }

    public static CombinedResult<TemplateGroupAccessControlEntryFactory, T1, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1>(this CombinedResult<TemplateGroupAccessControlEntryFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessRights(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateGroupAccessControlEntryFactory, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1>(this CombinedResult<T1, TemplateGroupAccessControlEntryFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessRights(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2>(this CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2>(this CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2>(this CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2, T3, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3>(this CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2, T3, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3>(this CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory, T3, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3>(this CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateGroupAccessControlEntryFactory, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateGroupAccessControlEntryFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2, T3, T4, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3, T4>(this CombinedResult<TemplateGroupAccessControlEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2, T3, T4, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3, T4>(this CombinedResult<T1, TemplateGroupAccessControlEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory, T3, T4, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateGroupAccessControlEntryFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateGroupAccessControlEntryFactory, T4, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateGroupAccessControlEntryFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TemplateGroupAccessControlEntryFactory, InnerTemplateGroupAccessControlEntryAccessRightsFactory> WithAccessRights<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateGroupAccessControlEntryFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRights(combinedResult.T5, subFactoryAction));
}
