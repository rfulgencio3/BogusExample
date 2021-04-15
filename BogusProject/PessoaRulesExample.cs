using Bogus;
using Bogus.Extensions.Brazil;

namespace BogusProject
{
    public class PessoaRulesExample
    {
        public PessoaRulesExample()
        {
            var fakerPessoa = new Faker<Pessoa>("pt_BR").StrictMode(true)
                .RuleFor(p => p.CPF, f => f.Person.Cpf())
                .RuleFor(p => p.Nome, f => f.Person.FullName)
                .RuleFor(p => p.UrlDaFoto, f => f.Person.Avatar)
                .RuleFor(p => p.IpDeAcesso, f => f.Internet.IpAddress())
                .RuleFor(p => p.NumeroDaConta, f => f.Finance.Account())
                .RuleFor(p => p.Saldo, f => f.Finance.Amount(1, 10000));
        }
    }
}
