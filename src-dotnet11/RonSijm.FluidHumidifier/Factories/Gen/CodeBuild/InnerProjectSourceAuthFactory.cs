// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectSourceAuthFactory(Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.SourceAuth>
{

    protected override Humidifier.CodeBuild.ProjectTypes.SourceAuth Create()
    {
        var sourceAuthResult = CreateSourceAuth();
        factoryAction?.Invoke(sourceAuthResult);

        return sourceAuthResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.SourceAuth CreateSourceAuth()
    {
        var sourceAuthResult = new Humidifier.CodeBuild.ProjectTypes.SourceAuth();

        return sourceAuthResult;
    }

} // End Of Class

public static class InnerProjectSourceAuthFactoryExtensions
{
}
