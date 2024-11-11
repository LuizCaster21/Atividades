public class Doidao
{
    // ... (restante da classe)

    public void RemoverElemento()
    {
        if (inicioFila != null)
        {
            // Remove da fila
            inicioFila = inicioFila.prox;
        }
        else if (inicioPilha != null)
        {
            // Remove da pilha
            inicioPilha = inicioPilha.prox;
        }
        else if (inicioLista != null)
        {
            // Remove do meio da lista (assumindo lista com pelo menos 2 elementos)
            NoLista anterior = inicioLista;
            NoLista atual = inicioLista.prox;
            while (atual.prox != null)
            {
                anterior = atual;
                atual = atual.prox;
            }
            anterior.prox = null;
        }
    }
}