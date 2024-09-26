// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ProvisioningTemplateFactory(string resourceName = null, Action<Humidifier.IoT.ProvisioningTemplate> factoryAction = null) : ResourceFactory<Humidifier.IoT.ProvisioningTemplate>(resourceName)
{

    internal InnerProvisioningTemplateProvisioningHookFactory PreProvisioningHookFactory { get; set; }

    protected override Humidifier.IoT.ProvisioningTemplate Create()
    {
        var provisioningTemplateResult = CreateProvisioningTemplate();
        factoryAction?.Invoke(provisioningTemplateResult);

        return provisioningTemplateResult;
    }

    private Humidifier.IoT.ProvisioningTemplate CreateProvisioningTemplate()
    {
        var provisioningTemplateResult = new Humidifier.IoT.ProvisioningTemplate
        {
            GivenName = InputResourceName,
        };

        return provisioningTemplateResult;
    }
    public override void CreateChildren(Humidifier.IoT.ProvisioningTemplate result)
    {
        base.CreateChildren(result);

        result.PreProvisioningHook ??= PreProvisioningHookFactory?.Build();
    }

} // End Of Class

public static class ProvisioningTemplateFactoryExtensions
{
    public static CombinedResult<ProvisioningTemplateFactory, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook(this ProvisioningTemplateFactory parentFactory, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null)
    {
        parentFactory.PreProvisioningHookFactory = new InnerProvisioningTemplateProvisioningHookFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PreProvisioningHookFactory);
    }

    public static CombinedResult<ProvisioningTemplateFactory, T1, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1>(this CombinedResult<ProvisioningTemplateFactory, T1> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProvisioningTemplateFactory, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1>(this CombinedResult<T1, ProvisioningTemplateFactory> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProvisioningTemplateFactory, T1, T2, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2>(this CombinedResult<ProvisioningTemplateFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProvisioningTemplateFactory, T2, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2>(this CombinedResult<T1, ProvisioningTemplateFactory, T2> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProvisioningTemplateFactory, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2>(this CombinedResult<T1, T2, ProvisioningTemplateFactory> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProvisioningTemplateFactory, T1, T2, T3, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3>(this CombinedResult<ProvisioningTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProvisioningTemplateFactory, T2, T3, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3>(this CombinedResult<T1, ProvisioningTemplateFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProvisioningTemplateFactory, T3, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3>(this CombinedResult<T1, T2, ProvisioningTemplateFactory, T3> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProvisioningTemplateFactory, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProvisioningTemplateFactory> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProvisioningTemplateFactory, T1, T2, T3, T4, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3, T4>(this CombinedResult<ProvisioningTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProvisioningTemplateFactory, T2, T3, T4, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3, T4>(this CombinedResult<T1, ProvisioningTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProvisioningTemplateFactory, T3, T4, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProvisioningTemplateFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProvisioningTemplateFactory, T4, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProvisioningTemplateFactory, T4> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProvisioningTemplateFactory, InnerProvisioningTemplateProvisioningHookFactory> WithPreProvisioningHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProvisioningTemplateFactory> combinedResult, Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreProvisioningHook(combinedResult.T5, subFactoryAction));
}
