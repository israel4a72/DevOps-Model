namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98m;
        var result = value.ToCents();
        Assert.AreEqual(27998, result);
    }
}