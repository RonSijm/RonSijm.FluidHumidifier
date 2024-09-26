// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeSubjectAlternativeNameMatchersFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers Create()
    {
        var subjectAlternativeNameMatchersResult = CreateSubjectAlternativeNameMatchers();
        factoryAction?.Invoke(subjectAlternativeNameMatchersResult);

        return subjectAlternativeNameMatchersResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers CreateSubjectAlternativeNameMatchers()
    {
        var subjectAlternativeNameMatchersResult = new Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers();

        return subjectAlternativeNameMatchersResult;
    }

} // End Of Class

public static class InnerVirtualNodeSubjectAlternativeNameMatchersFactoryExtensions
{
}
