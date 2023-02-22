namespace SampleNuget.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var novoTamanho = TratamentoString.LimitaTamanhoString("jefferson bompadre", 5);
        Assert.Equal(5, novoTamanho.Length);
    }
}