public class Doidao
{
    // ... (restante da classe)

    public void InserirElemento(int elemento)
    {
        if (elemento < 0)
        {
            // Insere na fila
            NoFila novoNo = new NoFila { elem = elemento, prox = inicioFila };
            inicioFila = novoNo;
        }
        else if (elemento % 2 == 0)
        {
            // Insere na pilha
            NoPilha novoNo = new NoPilha { elem = elemento, prox = inicioPilha };
            inicioPilha = novoNo;
        }
        else
        {
            // Insere na lista
            NoLista novoNo = new NoLista { elem = elemento };
            if (inicioLista == null)
            {
                inicioLista = novoNo;
            }
            else
            {
                NoLista atual = inicioLista;
                while (atual.prox != null)
                {
                    atual = atual.prox;
                }
                atual.prox = novoNo;
            }
        }
    }
}