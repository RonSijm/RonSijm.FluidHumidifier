// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerLdapServerMetadataFactory(Action<Humidifier.AmazonMQ.BrokerTypes.LdapServerMetadata> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.LdapServerMetadata>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.LdapServerMetadata Create()
    {
        var ldapServerMetadataResult = CreateLdapServerMetadata();
        factoryAction?.Invoke(ldapServerMetadataResult);

        return ldapServerMetadataResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.LdapServerMetadata CreateLdapServerMetadata()
    {
        var ldapServerMetadataResult = new Humidifier.AmazonMQ.BrokerTypes.LdapServerMetadata();

        return ldapServerMetadataResult;
    }

} // End Of Class

public static class InnerBrokerLdapServerMetadataFactoryExtensions
{
}
