using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Subscription.Domain.ValuesObjects
{
    public sealed class Email
    {
        public string? Endereco { get; private set; }

        //Contrutor público para gerar uma instância do Email
        public Email(string endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco))
                throw new ArgumentException("O email é obrigatório.");
            if (!IsValid(endereco))
                throw new ArgumentException("O email é inválido.");
           
            Endereco = endereco.ToLower();
        }
        private bool IsValid(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        public override string ToString() => Endereco ?? string.Empty;
    }
}
