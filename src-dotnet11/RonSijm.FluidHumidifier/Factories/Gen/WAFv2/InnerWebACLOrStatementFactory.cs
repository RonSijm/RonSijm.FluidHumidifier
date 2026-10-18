// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLOrStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.OrStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.OrStatement>
{

    protected override Humidifier.WAFv2.WebACLTypes.OrStatement Create()
    {
        var orStatementResult = CreateOrStatement();
        factoryAction?.Invoke(orStatementResult);

        return orStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.OrStatement CreateOrStatement()
    {
        var orStatementResult = new Humidifier.WAFv2.WebACLTypes.OrStatement();

        return orStatementResult;
    }

} // End Of Class

public static class InnerWebACLOrStatementFactoryExtensions
{
}
