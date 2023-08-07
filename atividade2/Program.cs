using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<Aluno> list = new List<Aluno>();
        
        while (true)
        {
            Aluno a = new Aluno();

            Console.Write(" \n 0- Se você quer encerrar \n 1- Se você quer cadastrar mais \n Digite: ");
            int opcaoEscolhida = Convert.ToInt32(Console.ReadLine()); 
            switch (opcaoEscolhida)
            {
                case 0:
                    
                    goto exit;
                   

                case 1:
                    Console.Write("Digite o numero de matrícula: ");
                    a.Matricula = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o nome: ");
                    a.Nome = Console.ReadLine();

                    Console.Write("Digite o Cpf: ");
                    a.Cpf = Console.ReadLine();

                    Console.Write("Digite a data de nascimento: ");
                    a.DataNascimento = DateOnly.Parse(Console.ReadLine());   
                    
                    list.Add(a);
                    break;
            }
        }
        exit:; ;

        foreach (Aluno a in list)
        {
            Console.WriteLine($"{a.Nome}, seu número de matrícula é: {a.Matricula}, seu cpf é: {a.Cpf}, e sua data de nascimento: {a.DataNascimento} ");
        }




    }
}