//Vamos falar sobre abstração em Orientação a Objetos
//Abstração é o processo de simplificar um sistema complexo, focando apenas nos aspectos essenciais e ignorando os detalhes desnecessários.
//Em OOP, a abstração é alcançada através de classes e objetos, onde uma classe define a estrutura e o comportamento de um objeto, enquanto oculta os detalhes internos que não são relevantes para o usuário da classe.    
//Por exemplo, ao usar um carro, você não precisa entender como o motor funciona para dirigir. Você só precisa saber como operar os controles (volante, acelerador, freio). O carro é uma abstração que simplifica a complexidade do motor e outros sistemas internos.
//Em C#, a abstração pode ser implementada usando classes abstratas e interfaces. Classes abstratas podem conter métodos abstratos (sem implementação) que devem ser implementados por classes derivadas, enquanto interfaces definem um contrato que as classes devem seguir.
//Aqui está um exemplo simples de abstração usando uma classe abstrata em C#:   
using System;
abstract class Animal
{
    // Método abstrato (sem implementação)
    public abstract void FazerSom();

    // Método concreto (com implementação)
    public void Dormir()
    {
        Console.WriteLine("O animal está dormindo.");
    }
}
class Cachorro : Animal
{
    // Implementação do método abstrato
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}
class Gato : Animal
{
    // Implementação do método abstrato
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia: Miau Miau!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal meuCachorro = new Cachorro();
        meuCachorro.FazerSom(); // Saída: O cachorro late: Au Au!
        meuCachorro.Dormir();   // Saída: O animal está dormindo.

        Animal meuGato = new Gato();
        meuGato.FazerSom();     // Saída: O gato mia: Miau Miau!
        meuGato.Dormir();       // Saída: O animal está dormindo.
    }
}
//Neste exemplo, a classe abstrata Animal define um método abstrato FazerSom() que deve ser implementado por qualquer classe derivada (Cachorro e Gato). A classe Animal também possui um método concreto Dormir() que pode ser usado por todas as subclasses. Isso permite que os detalhes específicos de como cada animal faz som sejam abstraídos, enquanto a funcionalidade comum (dormir) é compartilhada.
//A abstração ajuda a reduzir a complexidade do código, tornando-o mais fácil de entender, manter e reutilizar.     
//Além disso, a abstração promove o encapsulamento, pois os detalhes internos das classes são ocultados, expondo apenas o que é necessário para o usuário da classe. Isso leva a um design de software mais limpo e modular.    
//Em resumo, a abstração em OOP é uma técnica poderosa que ajuda a gerenciar a complexidade do software, permitindo que os desenvolvedores se concentrem nos aspectos essenciais de um sistema enquanto ocultam os detalhes desnecessários. 