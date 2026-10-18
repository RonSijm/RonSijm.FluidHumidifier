// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateEnrollmentFlagsV3Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3 Create()
    {
        var enrollmentFlagsV3Result = CreateEnrollmentFlagsV3();
        factoryAction?.Invoke(enrollmentFlagsV3Result);

        return enrollmentFlagsV3Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3 CreateEnrollmentFlagsV3()
    {
        var enrollmentFlagsV3Result = new Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV3();

        return enrollmentFlagsV3Result;
    }

} // End Of Class

public static class InnerTemplateEnrollmentFlagsV3FactoryExtensions
{
}
