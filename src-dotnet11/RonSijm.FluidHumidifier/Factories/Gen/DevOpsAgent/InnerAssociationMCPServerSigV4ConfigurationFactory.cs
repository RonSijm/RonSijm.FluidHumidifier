// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerSigV4ConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration Create()
    {
        var mCPServerSigV4ConfigurationResult = CreateMCPServerSigV4Configuration();
        factoryAction?.Invoke(mCPServerSigV4ConfigurationResult);

        return mCPServerSigV4ConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration CreateMCPServerSigV4Configuration()
    {
        var mCPServerSigV4ConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration();

        return mCPServerSigV4ConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerSigV4ConfigurationFactoryExtensions
{
}
