namespace Atc.TestTools.Tests
{
    public static class SubstituteExtensions
    {
        public static bool IsSubstitute(
            this object substitute)
            => substitute.GetType().Namespace == "Castle.Proxies";
    }
}