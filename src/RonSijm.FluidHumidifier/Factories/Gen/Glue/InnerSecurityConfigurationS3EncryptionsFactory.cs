// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSecurityConfigurationS3EncryptionsFactory(Action<Humidifier.Glue.SecurityConfigurationTypes.S3Encryptions> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SecurityConfigurationTypes.S3Encryptions>
{

    protected override Humidifier.Glue.SecurityConfigurationTypes.S3Encryptions Create()
    {
        var s3EncryptionsResult = CreateS3Encryptions();
        factoryAction?.Invoke(s3EncryptionsResult);

        return s3EncryptionsResult;
    }

    private Humidifier.Glue.SecurityConfigurationTypes.S3Encryptions CreateS3Encryptions()
    {
        var s3EncryptionsResult = new Humidifier.Glue.SecurityConfigurationTypes.S3Encryptions();

        return s3EncryptionsResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationS3EncryptionsFactoryExtensions
{
}
