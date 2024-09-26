// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLLabelMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.LabelMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.LabelMatchStatement>
{

    protected override Humidifier.WAFv2.WebACLTypes.LabelMatchStatement Create()
    {
        var labelMatchStatementResult = CreateLabelMatchStatement();
        factoryAction?.Invoke(labelMatchStatementResult);

        return labelMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.LabelMatchStatement CreateLabelMatchStatement()
    {
        var labelMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.LabelMatchStatement();

        return labelMatchStatementResult;
    }

} // End Of Class

public static class InnerWebACLLabelMatchStatementFactoryExtensions
{
}
