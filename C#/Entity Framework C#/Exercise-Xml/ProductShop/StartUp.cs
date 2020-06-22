using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<ProductShopProfile>());

            using (var db = new ProductShopContext())
            {
                //var inputXml = File.ReadAllText("./../../../Datasets/categories-products.xml");

                var result = ImportCategoryProducts(db, inputXml);

                Console.WriteLine(result);
            }
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var xmlSerializer =
                new XmlSerializer(typeof(ImportUserDto[]),
                new XmlRootAttribute("Users"));

            ImportUserDto[] userDtos;

            using (var reader = new StringReader(inputXml))
            {
                userDtos = (ImportUserDto[])xmlSerializer.Deserialize(reader);
            }

            var users = Mapper.Map<User[]>(userDtos);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var xmlSerializer =
                new XmlSerializer(typeof(ImportProductDto[]),
                new XmlRootAttribute("Products"));

            ImportProductDto[] productDtos;

            using (var reader = new StringReader(inputXml))
            {
                productDtos = (ImportProductDto[])xmlSerializer.Deserialize(reader);
            }

            var products = Mapper.Map<Product[]>(productDtos);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var xmlSerializer =
                new XmlSerializer(typeof(ImportCategoryDto[]),
                new XmlRootAttribute("Categories"));

            ImportCategoryDto[] categoryDtos;

            using (var reader = new StringReader(inputXml))
            {
                categoryDtos = ((ImportCategoryDto[])xmlSerializer
                    .Deserialize(reader))
                    .Where(c => c.Name != null)
                    .ToArray();
            }

            var categories = Mapper.Map<Category[]>(categoryDtos);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var xmlSerializer =
                new XmlSerializer(typeof(ImportCategoryProductDto[]),
                new XmlRootAttribute("CategoryProducts"));

            ImportCategoryProductDto[] categoryProductDtos;

            using (var reader = new StringReader(inputXml))
            {
                categoryProductDtos = ((ImportCategoryProductDto[])xmlSerializer
                    .Deserialize(reader))
                    .Where(cp => context.Categories.Any(c => c.Id == cp.CategoryId) 
                              && context.Products.Any(p => p.Id == cp.ProductId))
                    .ToArray();
            }

            var categoryProducts = Mapper.Map<CategoryProduct[]>(categoryProductDtos);

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Length}";
        }
    }
}