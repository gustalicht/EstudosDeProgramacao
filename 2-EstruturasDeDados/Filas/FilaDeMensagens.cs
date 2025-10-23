// a ideia primeiro criar um gerador de mensagens básiquinho e enviar tudo para uma fila.
using System;
using System.Security.Cryptography.X509Certificates;



class GeradorDeMensagens
{
    private int contador = 0;

    public string GerarMensagem()
    {
        contador++;
        return $"Mensagem {contador} gerada em {DateTime.Now}";
    }
}

class FilaDeMensagens
{
    private Queue<string> fila = new Queue<string>();
    private object lockObj = new object();

    public void Enfileirar(string mensagem)
    {
        lock (lockObj)
        {
            fila.Enqueue(mensagem);
            Console.WriteLine($"Enfileirado: {mensagem}");
        }
    }


    public string Desenfileirar()
    {
        lock (lockObj)
        {
            if (fila.Count > 0)
            {
                var mensagem = fila.Dequeue();
                Console.WriteLine($"Desenfileirado: {mensagem}");
                return mensagem;
            }
            else
            {
                return null;
            }
        }
    }

    public int ContarMensagens()
    {
        lock (lockObj)
        {
            return fila.Count;
        }
    }


}

// que problemas a fila resolve?
// A fila resolve problemas relacionados ao gerenciamento de mensagens assíncronas, permitindo que diferentes partes de um sistema se comuniquem de forma eficiente e organizada. Ela garante que as mensagens sejam processadas na ordem em que foram recebidas, evitando a perda de informações e facilitando a escalabilidade do sistema.// Além disso, a fila ajuda a desacoplar os componentes do sistema, permitindo que eles operem de maneira independente e lidem com picos de carga sem sobrecarregar os recursos disponíveis.
// Em resumo, a fila é uma ferramenta essencial para garantir a confiabilidade, eficiência e escalabilidade na comunicação entre diferentes partes de um sistema. 

