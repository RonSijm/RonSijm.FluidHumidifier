// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory(Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> factoryAction = null) : SubResourceFactory<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute>
{

    internal InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory ValueFactory { get; set; }

    protected override Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute Create()
    {
        var accessControlAttributeResult = CreateAccessControlAttribute();
        factoryAction?.Invoke(accessControlAttributeResult);

        return accessControlAttributeResult;
    }

    private Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute CreateAccessControlAttribute()
    {
        var accessControlAttributeResult = new Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute();

        return accessControlAttributeResult;
    }
    public override void CreateChildren(Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactoryExtensions
{
    public static CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue(this InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory parentFactory, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1>(this CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1>(this CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
