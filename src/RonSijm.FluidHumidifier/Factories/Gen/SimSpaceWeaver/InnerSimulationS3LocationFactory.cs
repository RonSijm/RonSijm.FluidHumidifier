// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SimSpaceWeaver;

public class InnerSimulationS3LocationFactory(Action<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.SimSpaceWeaver.SimulationTypes.S3Location>
{

    protected override Humidifier.SimSpaceWeaver.SimulationTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.SimSpaceWeaver.SimulationTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.SimSpaceWeaver.SimulationTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerSimulationS3LocationFactoryExtensions
{
}
