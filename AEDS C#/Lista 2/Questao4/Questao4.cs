public class Doidao
{
    // ... (restante da classe)

    public bool ContemElemento(int x)
    {
        return ContemElementoPilha(inicioPilha, x) ||
               ContemElementoFila(inicioFila, x) ||
               ContemElementoLista(inicioLista, x);
    }

    private bool ContemElementoPilha(NoPilha no, int x)
    {
        if (no == null)
            return false;
        return no.elem == x || ContemElementoPilha(no.prox, x);
    }

    private bool ContemElementoFila(NoFila no, int x)
    {
        if (no == null)
            return false;
        return no.elem == x || ContemElementoFila(no.prox, x);
    }

    private bool ContemElementoLista(NoLista no, int x)
    {
        if (no == null)
            return false;
        return no.elem == x || ContemElementoLista(no.prox, x);
    }
}