// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InstanceAccessControlAttributeConfigurationFactory(string resourceName = null, Action<Humidifier.SSO.InstanceAccessControlAttributeConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SSO.InstanceAccessControlAttributeConfiguration>(resourceName)
{

    internal List<InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> AccessControlAttributesFactories { get; set; } = [];

    protected override Humidifier.SSO.InstanceAccessControlAttributeConfiguration Create()
    {
        var instanceAccessControlAttributeConfigurationResult = CreateInstanceAccessControlAttributeConfiguration();
        factoryAction?.Invoke(instanceAccessControlAttributeConfigurationResult);

        return instanceAccessControlAttributeConfigurationResult;
    }

    private Humidifier.SSO.InstanceAccessControlAttributeConfiguration CreateInstanceAccessControlAttributeConfiguration()
    {
        var instanceAccessControlAttributeConfigurationResult = new Humidifier.SSO.InstanceAccessControlAttributeConfiguration
        {
            GivenName = InputResourceName,
        };

        return instanceAccessControlAttributeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SSO.InstanceAccessControlAttributeConfiguration result)
    {
        base.CreateChildren(result);

        result.AccessControlAttributes = AccessControlAttributesFactories.Any() ? AccessControlAttributesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InstanceAccessControlAttributeConfigurationFactoryExtensions
{
    public static CombinedResult<InstanceAccessControlAttributeConfigurationFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes(this InstanceAccessControlAttributeConfigurationFactory parentFactory, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null)
    {
        var factory = new InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory(subFactoryAction);
        parentFactory.AccessControlAttributesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1>(this CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1>(this CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2>(this CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2>(this CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2>(this CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3>(this CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3>(this CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory, T3, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3>(this CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory, T3> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceAccessControlAttributeConfigurationFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceAccessControlAttributeConfigurationFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3, T4>(this CombinedResult<InstanceAccessControlAttributeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3, T4>(this CombinedResult<T1, InstanceAccessControlAttributeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory, T3, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceAccessControlAttributeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceAccessControlAttributeConfigurationFactory, T4, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceAccessControlAttributeConfigurationFactory, T4> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceAccessControlAttributeConfigurationFactory, InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeFactory> WithAccessControlAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceAccessControlAttributeConfigurationFactory> combinedResult, Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlAttributes(combinedResult.T5, subFactoryAction));
}
