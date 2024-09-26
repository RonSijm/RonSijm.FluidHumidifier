// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRuleFixedResponseFactory(Action<Humidifier.VpcLattice.RuleTypes.FixedResponse> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.FixedResponse>
{

    protected override Humidifier.VpcLattice.RuleTypes.FixedResponse Create()
    {
        var fixedResponseResult = CreateFixedResponse();
        factoryAction?.Invoke(fixedResponseResult);

        return fixedResponseResult;
    }

    private Humidifier.VpcLattice.RuleTypes.FixedResponse CreateFixedResponse()
    {
        var fixedResponseResult = new Humidifier.VpcLattice.RuleTypes.FixedResponse();

        return fixedResponseResult;
    }

} // End Of Class

public static class InnerRuleFixedResponseFactoryExtensions
{
}
