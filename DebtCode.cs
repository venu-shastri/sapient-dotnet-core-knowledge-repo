using System;
using System.Collections.Generic;
using System.Xml;

namespace DebtCode
{
    public class TradeProcessor
    {
        public void ProcessTrades(System.IO.Stream stream)
        {
            // read rows
            var lines = new List<string>();
            using (var reader = new System.IO.StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in lines)
            {
                var fields = line.Split(new char[] { ',' });

                if (fields.Length != 3)
                {
                    Console.WriteLine("WARN: Line {0} malformed. Only {1} field(s) found.",lineCount, fields.Length);
                    continue;
                }

                if (fields[0].Length != 6 && fields[3].Length!=6)
                {
                    Console.WriteLine("WARN: Trade currencies on line {0} malformed: '{1}','{2}'",lineCount, fields[0],fields[3]);
                    continue;
                }

                int tradeAmount;
                if (!int.TryParse(fields[1], out tradeAmount))
                {
              Console.WriteLine("WARN: Trade amount on line {0} not a valid integer:'{1}'", lineCount, fields[1]);
                }

                decimal tradePrice;
                if (!decimal.TryParse(fields[2], out tradePrice))
                {
                    Console.WriteLine("WARN: Trade price on line {0} not a valid decimal:'{1}'", lineCount, fields[2]);
                }

                var sourceCurrencyCode = fields[0].Substring(0, 3);
                var destinationCurrencyCode = fields[3].Substring(3, 3);

                // calculate values
                var trade = new TradeRecord
                {
                    SourceCurrency = sourceCurrencyCode,
                    DestinationCurrency = destinationCurrencyCode,
                    Lots = tradeAmount / LotSize,
                    Price = tradePrice
                };

                trades.Add(trade);

                lineCount++;
               
            }


            System.Xml.XmlWriter _xmlDocWriter = System.Xml.XmlWriter.Create("TradeRecords.xml");
            _xmlDocWriter.WriteStartDocument(true);
            _xmlDocWriter.WriteStartElement("TradeRecords");
            foreach(TradeRecord record in trades)
            {
                _xmlDocWriter.WriteStartElement("TradeRecord");
                _xmlDocWriter.WriteElementString(nameof(record.SourceCurrency), record.SourceCurrency);
                _xmlDocWriter.WriteElementString(nameof(record.DestinationCurrency), record.DestinationCurrency);
                _xmlDocWriter.WriteElementString(nameof(record.Lots), record.Lots.ToString());
                _xmlDocWriter.WriteElementString(nameof(record.Price), record.Price.ToString());
                _xmlDocWriter.WriteEndElement();
            }
            _xmlDocWriter.WriteEndElement();
            _xmlDocWriter.WriteEndDocument();
            _xmlDocWriter.WriteEndDocument();
            _xmlDocWriter.Flush();
            _xmlDocWriter.Close();
            Console.WriteLine("INFO: {0} trades processed", trades.Count);
        }


        private static float LotSize = 100000f;
    }




    class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TradeProcessor _tradeProcessor = new TradeProcessor();
            _tradeProcessor.ProcessTrades(new System.IO.StreamReader("TradeRecords.csv").BaseStream);
        }
    }
}

/*
Expectation
1.Identify Violation of Design Principles
2. Refactor the code for testing and maintainability 
*/
