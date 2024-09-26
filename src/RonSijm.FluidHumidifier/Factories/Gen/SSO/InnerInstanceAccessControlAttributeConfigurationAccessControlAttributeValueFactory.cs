// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactory(Action<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue> factoryAction = null) : SubResourceFactory<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue>
{

    protected override Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue Create()
    {
        var accessControlAttributeValueResult = CreateAccessControlAttributeValue();
        factoryAction?.Invoke(accessControlAttributeValueResult);

        return accessControlAttributeValueResult;
    }

    private Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue CreateAccessControlAttributeValue()
    {
        var accessControlAttributeValueResult = new Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue();

        return accessControlAttributeValueResult;
    }

} // End Of Class

public static class InnerInstanceAccessControlAttributeConfigurationAccessControlAttributeValueFactoryExtensions
{
}
