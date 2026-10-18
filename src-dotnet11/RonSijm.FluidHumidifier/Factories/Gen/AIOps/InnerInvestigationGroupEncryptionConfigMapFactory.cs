// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AIOps;

public class InnerInvestigationGroupEncryptionConfigMapFactory(Action<Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap> factoryAction = null) : SubResourceFactory<Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap>
{

    protected override Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap Create()
    {
        var encryptionConfigMapResult = CreateEncryptionConfigMap();
        factoryAction?.Invoke(encryptionConfigMapResult);

        return encryptionConfigMapResult;
    }

    private Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap CreateEncryptionConfigMap()
    {
        var encryptionConfigMapResult = new Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap();

        return encryptionConfigMapResult;
    }

} // End Of Class

public static class InnerInvestigationGroupEncryptionConfigMapFactoryExtensions
{
}
