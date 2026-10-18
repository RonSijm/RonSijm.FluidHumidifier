// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateEnrollmentFlagsV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2 Create()
    {
        var enrollmentFlagsV2Result = CreateEnrollmentFlagsV2();
        factoryAction?.Invoke(enrollmentFlagsV2Result);

        return enrollmentFlagsV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2 CreateEnrollmentFlagsV2()
    {
        var enrollmentFlagsV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.EnrollmentFlagsV2();

        return enrollmentFlagsV2Result;
    }

} // End Of Class

public static class InnerTemplateEnrollmentFlagsV2FactoryExtensions
{
}
