using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace Poo.Conceitos;

public class Exemplo
{
    /*
     * 1 - Vetor / Array - Coleção com mesmo tipo de dados (Declarar o tamanho ao criar a variável)
     * 2 - List - Igual a vetor, com mais funcionalidades
     * 3 - Stack - Pilha - último a entrar, primeiro a sair /
     * primeiro a entrar, último a sair (LIFO) - Last In First Out
     * 4 - Queue - Adiciona em uma fila de forma sequencial -
     * Remove na mesma ordem - FIFO - First In First Out
     *
     *
     *
     * 
     */
    
    //1
    float[] notas = new float[10];
    
    //2
    List<float> listaNotas;

    private Stack<string> comandos;

    private Queue<string> salaEspera;

    private Hashtable Hashtable;

    public Exemplo()
    {
        // 1
        notas[0] = 2f;
        
        //2
        listaNotas = new List<float>();
        listaNotas = new List<float>(notas);
        listaNotas = new List<float>(90);
        
        
        comandos = new Stack<string>();
        comandos.Push("digitar");
        comandos.Push("formatar");
        comandos.Push("add negrito");

        comandos.Pop();
        
        
        salaEspera = new Queue<string>();
        salaEspera.Enqueue("Maria");
        salaEspera.Enqueue("José");
        salaEspera.Enqueue("Joao");

        salaEspera.Dequeue();
        
        Hashtable = new Hashtable();
        Hashtable.Add("asdf", salaEspera);



    }
}