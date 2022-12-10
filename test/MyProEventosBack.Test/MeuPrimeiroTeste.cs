namespace MyProEventosBack.Test;

public class MeuPrimeiroTeste
{
    private int myProperty;

    [Fact(DisplayName ="Testar")]
    public void Testar()
    {
        var variavel1 = 1;
        var variavel2 = 2;

        Assert.Equal(variavel1, variavel2);
    }
}