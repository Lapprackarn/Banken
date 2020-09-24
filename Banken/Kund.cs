using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Banken
{
    class Kund
    {
        public string Namn;
        public int Saldo;
        public string ShowSaldoInfo()
        {
            return Namn + Saldo;
            
                
            
        }
        
  


    }
}
