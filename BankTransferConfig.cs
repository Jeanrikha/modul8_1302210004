using System;
using System.IO;
using System.Text.Json;

namespace modul8_1302210004
{
    internal class BankTransferConfig
    {
        public btconfig config;
        public BankTransferConfig()
        {
            try
            {
                readConfig();
     
            }
            catch
            {
                setdefault();
            }
        }
        public btconfig readConfig()
        {
            string configFilePath = "bank_transfer_config.json";
            string json = File.ReadAllText(configFilePath);
            config = JsonSerializer.Deserialize<btconfig>(json);
            return config;
        }
        public void setdefault() 
        {
            string lang = "en";
            transfer transfer = new transfer("25000000","6500","15000");
            List <string> methods = new List<string> (){ "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            confirmation confirmation = new confirmation("yes","ya");
            config = new btconfig(lang,transfer,methods,confirmation);
            
        }

    }

    class btconfig
    {
        public string lang { get; set; }
        public transfer transfer { get; set; }
        public List <string> methods { get; set; }
        public confirmation confirmation { get; set; }

        public btconfig()
        {
            
        }
        public btconfig(string lang, transfer transfer, List <string> methods, confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }

    class transfer
    {
        public string threshold { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set;}
        public transfer()
        {

        }
        public transfer(string threshold, string low_fee, string high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
    class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
        public confirmation() 
        { 

        }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
