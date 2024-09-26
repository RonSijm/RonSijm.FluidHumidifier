// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class FlowEntitlementFactory(string resourceName = null, Action<Humidifier.MediaConnect.FlowEntitlement> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.FlowEntitlement>(resourceName)
{

    internal InnerFlowEntitlementEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowEntitlement Create()
    {
        var flowEntitlementResult = CreateFlowEntitlement();
        factoryAction?.Invoke(flowEntitlementResult);

        return flowEntitlementResult;
    }

    private Humidifier.MediaConnect.FlowEntitlement CreateFlowEntitlement()
    {
        var flowEntitlementResult = new Humidifier.MediaConnect.FlowEntitlement
        {
            GivenName = InputResourceName,
        };

        return flowEntitlementResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowEntitlement result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class FlowEntitlementFactoryExtensions
{
    public static CombinedResult<FlowEntitlementFactory, InnerFlowEntitlementEncryptionFactory> WithEncryption(this FlowEntitlementFactory parentFactory, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerFlowEntitlementEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<FlowEntitlementFactory, T1, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1>(this CombinedResult<FlowEntitlementFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowEntitlementFactory, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, FlowEntitlementFactory> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowEntitlementFactory, T1, T2, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<FlowEntitlementFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowEntitlementFactory, T2, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, FlowEntitlementFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowEntitlementFactory, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, FlowEntitlementFactory> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowEntitlementFactory, T1, T2, T3, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<FlowEntitlementFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowEntitlementFactory, T2, T3, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, FlowEntitlementFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowEntitlementFactory, T3, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, FlowEntitlementFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowEntitlementFactory, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowEntitlementFactory> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowEntitlementFactory, T1, T2, T3, T4, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<FlowEntitlementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowEntitlementFactory, T2, T3, T4, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, FlowEntitlementFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowEntitlementFactory, T3, T4, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowEntitlementFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowEntitlementFactory, T4, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowEntitlementFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowEntitlementFactory, InnerFlowEntitlementEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowEntitlementFactory> combinedResult, Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
