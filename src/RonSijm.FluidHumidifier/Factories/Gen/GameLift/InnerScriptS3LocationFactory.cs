// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerScriptS3LocationFactory(Action<Humidifier.GameLift.ScriptTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ScriptTypes.S3Location>
{

    protected override Humidifier.GameLift.ScriptTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.GameLift.ScriptTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.GameLift.ScriptTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerScriptS3LocationFactoryExtensions
{
}
