﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres!")]
        [Required(ErrorMessage = "Obrigatório informar o título!")]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Caracteres inválidos!")]
        [Required(ErrorMessage = "Obrigatório informar o gênero!")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        public string Genre { get; set; }
        [Range(1, 100, ErrorMessage = "Preço deve ser entre 1 e 100!")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Obrigatório informar o preço!")]
        public decimal Price { get; set; }
        public int DiretorID { get; set; }
        [Range(1, 100, ErrorMessage = "Obrigado Informar o diretor")]

        public Director Diretor { get; set; }
    }
}




 "Informe o nome do perfil de usuário."
 "Informe a situação do perfil de usuário."
 