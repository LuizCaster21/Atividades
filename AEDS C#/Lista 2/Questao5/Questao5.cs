public class Doidao
{
    // ... (restante da classe)

    public void TrocarPolaridade()
    {
        while (inicioPilha != null || inicioFila != null || inicioLista != null)
        {
            // Remover um elemento de qualquer estrutura não vazia
            int elemento = RemoverElemento();

            // Inserir o elemento na estrutura correta
            if (elemento > 0)
            {
                InserirNaFila(elemento);
            }
            else if (elemento % 2 != 0)
            {
                InserirNaPilha(elemento);
            }
            else
            {
                InserirNaLista(elemento);
            }
        }
    }

    // Função auxiliar para remover um elemento de qualquer estrutura não vazia
    private int RemoverElemento()
    {
        // ... (implementação para remover um elemento de qualquer estrutura não vazia)
        // A implementação exata dependerá de como você quer priorizar a remoção
        // Por exemplo, pode remover sempre da fila primeiro, depois da pilha e por último da lista
    }

    // Funções auxiliares para inserir elementos nas respectivas estruturas
    private void InserirNaFila(int elemento)
    {
        // ... (implementação para inserir na fila)
    }

    private void InserirNaPilha(int elemento)
    {
        // ... (implementação para inserir na pilha)
    }

    private void InserirNaLista(int elemento)
    {
        // ... (implementação para inserir na lista)
    }
}