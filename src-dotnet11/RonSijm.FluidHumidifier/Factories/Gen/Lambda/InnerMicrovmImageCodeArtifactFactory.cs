// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageCodeArtifactFactory(Action<Humidifier.Lambda.MicrovmImageTypes.CodeArtifact> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.CodeArtifact>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.CodeArtifact Create()
    {
        var codeArtifactResult = CreateCodeArtifact();
        factoryAction?.Invoke(codeArtifactResult);

        return codeArtifactResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.CodeArtifact CreateCodeArtifact()
    {
        var codeArtifactResult = new Humidifier.Lambda.MicrovmImageTypes.CodeArtifact();

        return codeArtifactResult;
    }

} // End Of Class

public static class InnerMicrovmImageCodeArtifactFactoryExtensions
{
}
