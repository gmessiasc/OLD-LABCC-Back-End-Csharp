﻿using LABCC.BackEnd.Domain.Validators.DataTypeAttributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LABCC.BackEnd.Application.DTO.Colecoes;

namespace LABCC.BackEnd.Application.DTO.Modelos;

public sealed class ModeloDTOResponse
{
  [Required(ErrorMessage = "{0} é obrigatório.")]
  [MaxLength(50, ErrorMessage = " {0} deve possuir no máximo 50 caracteres. ")]
  [DefaultValue("Camiseta Muito Bacana")]
  [Description("Nome do modelo, no máximo 50 caracteres.")]
  public string NomeDoModelo { get; set; }

  public ColecaoDTOResponseOnlyId colecao { get; set; }

  [TipoDeModelo]
  [Required(ErrorMessage = "{0} é obrigatório.")]
  [MaxLength(20, ErrorMessage = " {0} deve possuir no máximo 20 caracteres. ")]
  [DefaultValue("Camisa")]
  [Description("Tipo do modelo, opções disponíveis: 'Bermuda', 'Biquini', 'Bolsa', 'Boné', 'Calça', 'Calçados', 'Camisa', 'Chapéu' ou 'Saia'.")]
  public string? TipoDeModelo { get; set; }

  [ModeloLayout]
  [Required(ErrorMessage = "{0} é obrigatório.")]
  [MaxLength(20, ErrorMessage = " {0} deve possuir no máximo 20 caracteres. ")]
  [DefaultValue("Bordado")]
  [Description("Bordado do modelo, opções válidas: 'Bordado', 'Estampa' ou 'Liso'.")]
  public string? Layout { get; set; }

  [Status]
  [Required(ErrorMessage = "{0} é obrigatório.")]
  [MaxLength(10, ErrorMessage = " {0} deve possuir no máximo 10 caracteres. ")]
  [DefaultValue("Ativo")]
  [Description("Estado da coleção no sistema, pode ser 'Ativo' ou 'Inativo'")]
  public string? Status { get; set; }
}