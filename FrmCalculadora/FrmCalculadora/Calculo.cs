using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace FrmCalculadora
{
    class Calcular
    {
        #region Atributos
      
       

        public decimal valorUm { get; set; }
        public decimal valorDois { get; set; }
  

       
     
        #endregion Atributos


        public Calcular()
        {
           
        }

        public string soma()
        {
            FrmCalculadora frmCalcular = new FrmCalculadora();
            this.valorUm = Convert.ToDecimal(frmCalcular.valorUm.ToString());
            this.valorDois = Convert.ToDecimal(frmCalcular.valorDois.ToString());
            decimal somar = this.valorUm + this.valorDois;
            string valorFinal = Convert.ToString(somar);

            return valorFinal;
        }
    }
}
