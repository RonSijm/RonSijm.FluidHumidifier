// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineVariableDeclarationFactory(Action<Humidifier.CodePipeline.PipelineTypes.VariableDeclaration> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.VariableDeclaration>
{

    protected override Humidifier.CodePipeline.PipelineTypes.VariableDeclaration Create()
    {
        var variableDeclarationResult = CreateVariableDeclaration();
        factoryAction?.Invoke(variableDeclarationResult);

        return variableDeclarationResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.VariableDeclaration CreateVariableDeclaration()
    {
        var variableDeclarationResult = new Humidifier.CodePipeline.PipelineTypes.VariableDeclaration();

        return variableDeclarationResult;
    }

} // End Of Class

public static class InnerPipelineVariableDeclarationFactoryExtensions
{
}
