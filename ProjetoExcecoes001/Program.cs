using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoExcecoes001.Entitedes;
using ProjetoExcecoes001.Entitedes.Exceptions;

namespace ProjetoExcecoes001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Entrada (dd/MM/yyyy): ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Saida (dd/MM/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());

                Reservas reserva = new Reservas(quarto, entrada, saida);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com nova data  para atualizar reserva: ");
                Console.Write("Entrada (dd/MM/yyyy): ");
                entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Saida (dd/MM/yyyy): ");
                saida = DateTime.Parse(Console.ReadLine());

                //datas futuras
                reserva.UpdateData(entrada, saida);
                Console.WriteLine("Reserva : " + reserva);
            }
            catch (DominioExcecao e)//havendo exceceção acima ( vamos capturar)
            {
                Console.WriteLine("Error na reserva" + e.Message);
            }
            catch(FormatException e) {

                Console.WriteLine("Erro na formatação: digite apenas numero : " + e.Message);
            }
            catch(Exception e) {

                Console.WriteLine("Erro inesperado" + e.Message);
            }
        }
    }
}






