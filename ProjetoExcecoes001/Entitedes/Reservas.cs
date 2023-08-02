using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoExcecoes001.Entitedes.Exceptions;

namespace ProjetoExcecoes001.Entitedes
{
    internal class Reservas
    {

        public int NumeroQuarto { get; set; }//Room Number
        public DateTime Entrada { get; set; }// Chekin (data da entrada)
        public DateTime Saida { get; set; }//Chekout

        public Reservas()
        {

        }

        public Reservas(int numeroQuarto, DateTime entrada, DateTime saida)
        {

            if (saida <= entrada)
            {
                throw new DominioExcecao ("data de saida deve ser informada depois entrada:");
            }

            NumeroQuarto = numeroQuarto;
            Entrada = entrada;
            Saida = saida;
        }

        public double Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Entrada);
            return (int)duracao.TotalDays;
        }

        public void UpdateData(DateTime entrada, DateTime saida)
        {

            DateTime now = DateTime.Now;
            if (entrada < now || saida < now)
            {
                throw new DominioExcecao("datas da RESERVA, devem ser datas FUTURAS");
            }
            else if (saida <= entrada)
            {
                throw new DominioExcecao("data de SAIDA deve ser informada DEPOIS entrada:");
            }

            Entrada = entrada;
            Saida = saida;
        }

        public override string ToString()
        {
            return "Room "
                + NumeroQuarto
                + ", check-in: "
                + Entrada.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Saida.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " Noites";
        }
    }
}
