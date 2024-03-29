﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.BarControls.Ticket ticket = new WindowsFormsApplication1.BarControls.Ticket();

            //ticket.HeaderImage = "C:\imagen.jpg"; //esta propiedad no es obligatoria

            ticket.AddHeaderLine("STARBUCKS COFFEE TAMAULIPAS");
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine("AV. TAMAULIPAS NO. 5 LOC. 101");
            ticket.AddHeaderLine("MEXICO, DISTRITO FEDERAL");

            //El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia
            //de que al final de cada linea agrega una linea punteada "=========="
            ticket.AddSubHeaderLine("Caja # 1 - Ticket # 1");
            ticket.AddSubHeaderLine("Le atendió: Prueba");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            //El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion
            //del producto y el tercero es el precio
            ticket.AddItem("1", "Articulo Prueba", "15.00");
            ticket.AddItem("2", "Articulo Prueba", "25.00");

            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            ticket.AddTotal("SUBTOTAL", "29.75");
            ticket.AddTotal("IVA", "5.25");
            ticket.AddTotal("TOTAL", "35.00");
            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            ticket.AddTotal("RECIBIDO", "50.00");
            ticket.AddTotal("CAMBIO", "15.00");
            ticket.AddTotal("", "");//Ponemos un total en blanco que sirve de espacio
            ticket.AddTotal("USTED AHORRO", "0.00");

            //El metodo AddFooterLine funciona igual que la cabecera
            ticket.AddFooterLine("EL CAFE ES NUESTRA PASION...");
            ticket.AddFooterLine("VIVE LA EXPERIENCIA EN STARBUCKS");
            ticket.AddFooterLine("GRACIAS POR TU VISITA");

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.
            //ticket.PrintTicket("EPSON TM-U220 Receipt"); 
            ticket.PrintTicket("EPSON Stylus CX5600 Series");

        }

        

    }
}
