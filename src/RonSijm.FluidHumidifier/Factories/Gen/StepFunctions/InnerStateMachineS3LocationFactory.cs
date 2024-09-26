// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineS3LocationFactory(Action<Humidifier.StepFunctions.StateMachineTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineTypes.S3Location>
{

    protected override Humidifier.StepFunctions.StateMachineTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.StepFunctions.StateMachineTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.StepFunctions.StateMachineTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerStateMachineS3LocationFactoryExtensions
{
}
