// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceCertificateDetailsFactory(Action<Humidifier.RDS.DBInstanceTypes.CertificateDetails> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.CertificateDetails>
{

    protected override Humidifier.RDS.DBInstanceTypes.CertificateDetails Create()
    {
        var certificateDetailsResult = CreateCertificateDetails();
        factoryAction?.Invoke(certificateDetailsResult);

        return certificateDetailsResult;
    }

    private Humidifier.RDS.DBInstanceTypes.CertificateDetails CreateCertificateDetails()
    {
        var certificateDetailsResult = new Humidifier.RDS.DBInstanceTypes.CertificateDetails();

        return certificateDetailsResult;
    }

} // End Of Class

public static class InnerDBInstanceCertificateDetailsFactoryExtensions
{
}
