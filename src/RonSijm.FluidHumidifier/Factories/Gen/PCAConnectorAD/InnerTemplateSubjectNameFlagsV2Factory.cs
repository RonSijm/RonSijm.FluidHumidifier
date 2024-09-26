// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateSubjectNameFlagsV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2 Create()
    {
        var subjectNameFlagsV2Result = CreateSubjectNameFlagsV2();
        factoryAction?.Invoke(subjectNameFlagsV2Result);

        return subjectNameFlagsV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2 CreateSubjectNameFlagsV2()
    {
        var subjectNameFlagsV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.SubjectNameFlagsV2();

        return subjectNameFlagsV2Result;
    }

} // End Of Class

public static class InnerTemplateSubjectNameFlagsV2FactoryExtensions
{
}
