// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateSubjectNameFlagsV3Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3 Create()
    {
        var subjectNameFlagsV3Result = CreateSubjectNameFlagsV3();
        factoryAction?.Invoke(subjectNameFlagsV3Result);

        return subjectNameFlagsV3Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3 CreateSubjectNameFlagsV3()
    {
        var subjectNameFlagsV3Result = new Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV3();

        return subjectNameFlagsV3Result;
    }

} // End Of Class

public static class InnerTemplateSubjectNameFlagsV3FactoryExtensions
{
}
