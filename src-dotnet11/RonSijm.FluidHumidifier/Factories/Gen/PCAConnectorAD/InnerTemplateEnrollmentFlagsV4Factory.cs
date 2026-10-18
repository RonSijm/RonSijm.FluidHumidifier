// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateEnrollmentFlagsV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4 Create()
    {
        var enrollmentFlagsV4Result = CreateEnrollmentFlagsV4();
        factoryAction?.Invoke(enrollmentFlagsV4Result);

        return enrollmentFlagsV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4 CreateEnrollmentFlagsV4()
    {
        var enrollmentFlagsV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV4();

        return enrollmentFlagsV4Result;
    }

} // End Of Class

public static class InnerTemplateEnrollmentFlagsV4FactoryExtensions
{
}
