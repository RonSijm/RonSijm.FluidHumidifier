namespace RonSijm.FluidHumidifier.Factories.IAM
{
    public static class RoleAsArnExtension
    {
        public static FnSub AsArn(this Role role)
        {
            return Fn.Sub($"arn:aws:iam::${{AWS::AccountId}}:role/{role.RoleName}");
        }
    }
}
