// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobKeyNameConstraintFactory(Action<Humidifier.S3.JobTypes.KeyNameConstraint> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.KeyNameConstraint>
{

    protected override Humidifier.S3.JobTypes.KeyNameConstraint Create()
    {
        var keyNameConstraintResult = CreateKeyNameConstraint();
        factoryAction?.Invoke(keyNameConstraintResult);

        return keyNameConstraintResult;
    }

    private Humidifier.S3.JobTypes.KeyNameConstraint CreateKeyNameConstraint()
    {
        var keyNameConstraintResult = new Humidifier.S3.JobTypes.KeyNameConstraint();

        return keyNameConstraintResult;
    }

} // End Of Class

public static class InnerJobKeyNameConstraintFactoryExtensions
{
}
