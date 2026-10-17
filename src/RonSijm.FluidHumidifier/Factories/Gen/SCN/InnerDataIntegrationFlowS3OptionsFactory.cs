// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowS3OptionsFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.S3Options> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.S3Options>
{

    protected override Humidifier.SCN.DataIntegrationFlowTypes.S3Options Create()
    {
        var s3OptionsResult = CreateS3Options();
        factoryAction?.Invoke(s3OptionsResult);

        return s3OptionsResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.S3Options CreateS3Options()
    {
        var s3OptionsResult = new Humidifier.SCN.DataIntegrationFlowTypes.S3Options();

        return s3OptionsResult;
    }

} // End Of Class

public static class InnerDataIntegrationFlowS3OptionsFactoryExtensions
{
}
