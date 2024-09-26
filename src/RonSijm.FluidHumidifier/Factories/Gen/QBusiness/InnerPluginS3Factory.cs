// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPluginS3Factory(Action<Humidifier.QBusiness.PluginTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PluginTypes.S3>
{

    protected override Humidifier.QBusiness.PluginTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.QBusiness.PluginTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.QBusiness.PluginTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerPluginS3FactoryExtensions
{
}
