// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionS3PropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.S3PropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.S3PropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.S3PropertiesInput Create()
    {
        var s3PropertiesInputResult = CreateS3PropertiesInput();
        factoryAction?.Invoke(s3PropertiesInputResult);

        return s3PropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.S3PropertiesInput CreateS3PropertiesInput()
    {
        var s3PropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.S3PropertiesInput();

        return s3PropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionS3PropertiesInputFactoryExtensions
{
}
