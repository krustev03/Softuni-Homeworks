using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System;
using System.Linq;
using AutoMapper.QueryableExtensions;
using CarDealer.Dtos.Export;
using System.Text;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<CarDealerProfile>());

            using (var db = new CarDealerContext())
            {
                //var inputXml = File.ReadAllText("./../../../Datasets/sales.xml");

                var result = GetLocalSuppliers(db);

                Console.WriteLine(result);
            }
        }


        public static string GetLocalSuppliers(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();

            var suppliers = context
                .Suppliers
                .Where(s => s.IsImporter)
                .ProjectTo<ExportLocalSuppliersDto>()
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportLocalSuppliersDto[]),
                                new XmlRootAttribute("suppliers"));

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            using (var writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, suppliers, namespaces);
            }

            return sb.ToString().TrimEnd();
        }
    }
}