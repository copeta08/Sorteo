using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio08_UD06
{
    public partial class Form1 : Form
    {
        const int kNum = 6;

        ArrayList numSorteo = new ArrayList(kNum);
        ArrayList numJugador = new ArrayList(kNum);

        void realizarSorteo(ArrayList numeroSorteo)
        {
            int cont, num;
            Random r = new Random();

            cont = 0;
            while (cont < kNum)
            {
                num = r.Next(1, 50);

                if (numerosSorteo.Contains(num) == false)
                {
                    numerosSorteo.Add(num);
                    cont++;
                }
            }
        }

        void introducirNum(ArrayList list)
        {

            int i = 0;

            while (i < 6)
            {
                int num = int.Parse(Interaction.InputBox("Introduce un número"));

                if (num > 0 && num < 50 && list.Contains(num) == false)
                {
                    list.Add(num);
                    i++;
                }
                else
                {
                    MessageBox.Show("El número debe estar entre el 1 y el 49 y no debe estar repetido.");
                }
            }
        }

        string mostrarLista(ArrayList lis1)
        {
            string texto;

            texto = "";
            for (int i = 0; i < lis1.Count; i++)
            {
                texto = texto + lis1[i] + ", ";
            }

            texto = texto + "\n";

            return texto;
        }

        int comprobarResultado(ArrayList listSorteo, ArrayList listJugador)
        {
            int cont = 0;

            for (int i = 0; i < kNum; i++)
            {
                if ((int)listSorteo[i] == (int)listJugador[i])
                {
                    cont++;
                }
            }

            return cont;
        } //función que comprueba que los números coincidan línea por línea.

        /*int comprobarRes(ArrayList lisSorteo, ArrayList lisJugador) 
        {
            int conta = 0;

            for (int i = 0; i < kNum; i++)
            {
                for (int j = 0; j < kNum; j++)
                {
                    if ((int)lisJugador[i] == (int)lisSorteo[j])
                    {
                        conta++;
                    }
                }
            }
            return conta;
        }*/   //función que comprueba que los número introducidos son iguales sin importar el orden

        public Form1()
        {
            InitializeComponent();
        }

        private void bSorteo_Click(object sender, EventArgs e)
        {
            numSorteo.Clear();
            realizarSorteo(numSorteo);

            MessageBox.Show(mostrarLista(numSorteo));
        }

        private void bJugar_Click(object sender, EventArgs e)
        {
            numJugador.Clear();
            introducirNum(numJugador);

            MessageBox.Show(mostrarLista(numJugador));
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            int total = comprobarResultado(numSorteo, numJugador);

            string resultado = "Coinciden " + total + " números. \n\n" + mostrarLista(numSorteo) + mostrarLista(numJugador);

            MessageBox.Show(resultado);
        }
    }
}
