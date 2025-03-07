using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.exercicios
{
    internal class exercicio1
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Digite sua data de nascimento");
        //    string nascimentoRecebido = Console.ReadLine();

        //    DateTime nascimento;
        //    if (DateTime.TryParseExact(nascimentoRecebido, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out nascimento))
        //    {
        //        DateTime dataAtual = DateTime.Now;
                
        //        int anos = dataAtual.Year - nascimento.Year;
        //        int meses = dataAtual.Month - nascimento.Month;
        //        int dias = dataAtual.Day - nascimento.Day;

        //        if (meses < 0 || (meses == 0 && dias < 0))
        //        {
        //            anos--;
        //            meses += 12;
        //        }

        //        if (dias < 0)
        //        {
        //            var ultimoDiaMesAnterior = new DateTime(dataAtual.Year, dataAtual.Month, 1).AddDays(-1);
        //            dias += DateTime.DaysInMonth(ultimoDiaMesAnterior.Year, ultimoDiaMesAnterior.Month);
        //        }
                
        //        Console.WriteLine($"Sua idade é: {anos} anos, {meses} meses e {dias} dias.");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Data de nascimento inválida. Por favor, use o formato dd/mm/aaaa.");
        //    }
        //}
    }
}