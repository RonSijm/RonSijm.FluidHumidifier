// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewaySubjectAlternativeNameMatchersFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers Create()
    {
        var subjectAlternativeNameMatchersResult = CreateSubjectAlternativeNameMatchers();
        factoryAction?.Invoke(subjectAlternativeNameMatchersResult);

        return subjectAlternativeNameMatchersResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers CreateSubjectAlternativeNameMatchers()
    {
        var subjectAlternativeNameMatchersResult = new Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers();

        return subjectAlternativeNameMatchersResult;
    }

} // End Of Class

public static class InnerVirtualGatewaySubjectAlternativeNameMatchersFactoryExtensions
{
}
