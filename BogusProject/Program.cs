using Bogus;
using Bogus.Extensions.Brazil;
using System;

namespace BogusProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                var faker = new Faker("pt_BR");
                string gender = faker.Person.Gender.ToString();

                Console.WriteLine("Nome: " + faker.Person.FirstName);
                Console.WriteLine("Sobrenome: " + faker.Person.LastName);
                Console.WriteLine("Sexo: " + gender);
                Console.WriteLine("Empresa: " + faker.Company.CompanyName());
                Console.WriteLine("Nascimento: " + faker.Date.Between(DateTime.Now.AddYears(-80), DateTime.Now.AddYears(-18)));
                Console.WriteLine("CPF: " + faker.Person.Cpf());
                Console.WriteLine($"Cidade Endereço: {faker.Address.City()}");
                Console.WriteLine("E-mail: " + faker.Internet.Email(faker.Person.FirstName).ToLower());
                Console.WriteLine("\n");
            }
            Console.ReadKey();

            
        }
    }
}
