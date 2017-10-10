using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clientSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
            Console.WriteLine("--------Conversion------");
            Console.WriteLine(stub.ConversionEuroToDh(34));
            Console.WriteLine("--------Consulter un Compte------");
            ServiceReference1.compte cp = stub.getCompte(2);
            Console.WriteLine("Solde " + cp.solde);
            Console.WriteLine("--------Liste des comptes------");
            ServiceReference1.compte[] cptes = stub.getComptes();
            for (int i = 0; i < cptes.Length;i++ ) {
                Console.WriteLine("--------" + cptes[i].solde);
            }
            Console.ReadLine();
        }
    }
}
