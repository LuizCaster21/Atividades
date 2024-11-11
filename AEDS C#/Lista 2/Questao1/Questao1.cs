public class Doidao
{
    // ... (restante da classe)

    public int CalcularTamanhoRecursivo()
    {
        int tamanho = 0;

        // Calculando o tamanho da pilha
        tamanho += CalcularTamanhoPilha(inicioPilha);

        // Calculando o tamanho da fila
        tamanho += CalcularTamanhoFila(inicioFila);

        // Calculando o tamanho da lista
        tamanho += CalcularTamanhoLista(inicioLista);

        return tamanho;
    }

    private int CalcularTamanhoPilha(NoPilha no)
    {
        if (no == null)
            return 0;
        else
            return 1 + CalcularTamanhoPilha(no.prox);
    }

    private int CalcularTamanhoFila(NoFila no)
    {
        if (no == null)
            return 0;
        else
            return 1 + CalcularTamanhoFila(no.prox);
    }

    private int CalcularTamanhoLista(NoLista no)
    {
        if (no == null)
            return 0;
        else
            return 1 + CalcularTamanhoLista(no.prox);
    }
}