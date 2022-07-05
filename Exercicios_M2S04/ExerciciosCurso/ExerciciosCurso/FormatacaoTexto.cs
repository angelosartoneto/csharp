using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCurso
{
    public static class FormatacaoTexto
    {  

            static void Impressao() {

                FichaInscricao fo = new FichaInscricao();

            if (fo.ValorDesconto > 0)
            {
                Console.WriteLine("Nome: " + fo.Nome + ", Curso: " + fo.Curso + ", Valor do Curso: " + fo.ValorCurso + ", Valor do Desconto: " + fo.ValorDesconto);
                

            } else if (fo.ValorDesconto > 0 && fo.Idade < 18)
            {
                Console.WriteLine("Nome: " + fo.Nome + ", Curso: " + fo.Curso + ", Valor do Curso: " + fo.ValorCurso + ", Valor do Desconto: " + fo.ValorDesconto + ", Idade: " + fo.Idade);

            } else
            {
                Console.WriteLine("Nome: " + fo.Nome + ", Curso: " + fo.Curso + ", Valor do Curso: " + fo.ValorCurso);
            }
            }
        

    }

}

//Criar uma classe static chamada FormatacaoTexto para efetuar uma sobrecarga que vai devolver a string formatada:
//Criar uma classe static chamada FormatacaoTexto e criar método para efetuar uma sobrecarga que vai devolver a string formatada:
//**Formatação 1 * *-Nome, Curso, Valor Curso
//**Formatação 2** - Nome, Curso, Valor Curso, Valor Desconto
//**Formatação 3** - Nome, Curso, Valor Curso, Valor Desconto, Idade
//Regra
//===============================
//Se desconto for igual que zero utilizar **Formatação 1**
//Se desconto for maior que zero utilizar **Formatação 2**
//Se desconto for maior que zero e idade menor que 18 anos utilizar  **Formatação 3**