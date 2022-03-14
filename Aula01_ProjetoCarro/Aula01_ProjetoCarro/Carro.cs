using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_ProjetoCarro
{
    class Carro
    {
        public string cor;
        public int  anoFabricacao;
        public string modelo;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public bool estaLigado;


        public Carro(string _cor, int _anoFabricacao, string _modelo, float _velocidadeMaxima)
        {
            cor = _cor;
            anoFabricacao = _anoFabricacao;
            modelo = _modelo;
            velocidadeMaxima = _velocidadeMaxima;
            velocidadeAtual = 0;
            estaLigado = false;
        }     

        public void Ligar()
        {
            if(estaLigado == false)
            {
                estaLigado = true;
                Console.WriteLine("Ligando o carro");
                Console.ReadLine();
                Console.WriteLine("Carro esta ligado!");
            }
            else
            {
                Console.WriteLine("Carro ja esta ligado, animal!!");
            }
            
        }
        public void Desligar()
        {
            if (estaLigado == true)
            {
                estaLigado = false;
                Console.WriteLine("desligando o carro");
                Console.ReadLine();
                Console.WriteLine("Carro esta desligado!");
            }
            else
            {
                Console.WriteLine("Carro ja esta desligado, animal!!");
            }

        }

    }
}
