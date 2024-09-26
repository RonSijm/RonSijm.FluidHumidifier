// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateSubjectNameFlagsV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4 Create()
    {
        var subjectNameFlagsV4Result = CreateSubjectNameFlagsV4();
        factoryAction?.Invoke(subjectNameFlagsV4Result);

        return subjectNameFlagsV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4 CreateSubjectNameFlagsV4()
    {
        var subjectNameFlagsV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV4();

        return subjectNameFlagsV4Result;
    }

} // End Of Class

public static class InnerTemplateSubjectNameFlagsV4FactoryExtensions
{
}
