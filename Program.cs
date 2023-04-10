using modul8_1302210004;
using System.Text.Json;
using System.Xml;

class program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        if(config.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer");
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
        }
        string uang = string.Format(Console.ReadLine());
    }
}
