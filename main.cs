using System;

class MainClass {


  public static void Main (string[] args) {  
    
    string opcao; //VARIÁVEL PARA RECEBER O VALOR DA OPÇÃO

    Console.WriteLine("S - Para somar | M - Para média bimestral");
    opcao = Console.ReadLine();

    if ( opcao == "S"){

      somaNumero();

    }else if (opcao == "M") {

      mediaAluno();

    }else{

      Console.WriteLine("Opção inválida!");

    }
    
    
    
  }

  public static void somaNumero(){

    int valor1,valor2; 
    Console.WriteLine("Digite o primeiro Valor");
    valor1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo Valor");    
    valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine("VALOR 1: " + valor1);
    Console.WriteLine("VALOR 2: " + valor2);
    Console.WriteLine("A SOMA DOS VALORES É: " + (valor1 + valor2));

  } 
    //FUNÇÃO PARA EXIBIR A MÉDIA DO ALUNO  
    public static void mediaAluno(){

    //DECLARAÇÃO DE VARIÁVEIS DENTRO DA FUNÇÃO MÉDIA ALUNO 
    int cont = 1; //CONTADOR PARA WHILE
    double [] notas = new int[4]; //VETOR DO TIPO DOUBLE PARA ARMAZENAR AS NOTAS
    double soma = 0; //VARIÁVEL DO TIPO DOBLE PARA NOTAS A SOMA DAS NOTAS

    while(cont <= 4){ //WHILE PARA 

      Console.WriteLine("Digite o {0} º Valor",cont); //SOLICITAR AO USUÁRIO PARA DIGITAR AS NOTAS
      notas[cont-1] = double.Parse(Console.ReadLine()); // AS NOTAS SERÃO SALVAS DENTRO DE UM VETOR
      soma += (notas[cont-1]); // SOMA VAI RECEBER ELA MESMA + A PRÓXIMA NOTA
      cont += 1; // CONTADOR PARA SAIR DO WHILE QUANDO A CONDIÇÃO FOR FALSA
      
    }

    Console.WriteLine("MÉDIA \n" + (soma/4) ); //EXIBI O RESULTADO DA MÉDIA

  } 



}