﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaSys.Dominio;
using PizzariaSys.Dominio.Entidades;

namespace PizzariaSys.App.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " * Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " * Campo obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = " * Campo obrigatório")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$",ErrorMessage = "Digite somente números")]
        public int Numero { get; set; }
        
        public string Email { get; set; }

        [Required(ErrorMessage = " * Campo obrigatório")]
        public string Telefone { get; set; }

        public ClienteViewModel()
        {
            
        }

        public ClienteViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Sobrenome = cliente.Sobrenome;
            Numero = cliente.Numero;
            Email = cliente.Email;
            Telefone = cliente.Telefone;
        }
    }
}
