// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLAndStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.AndStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.AndStatement>
{

    protected override Humidifier.WAFv2.WebACLTypes.AndStatement Create()
    {
        var andStatementResult = CreateAndStatement();
        factoryAction?.Invoke(andStatementResult);

        return andStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.AndStatement CreateAndStatement()
    {
        var andStatementResult = new Humidifier.WAFv2.WebACLTypes.AndStatement();

        return andStatementResult;
    }

} // End Of Class

public static class InnerWebACLAndStatementFactoryExtensions
{
}
