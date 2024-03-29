﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Bridge.Model;

public class EventosModel
{
    public int IdDoEvento { get; set; }

    [ForeignKey("UsuarioModel")]
    public int IdDoUsuario { get; set; }

    public string NomeDoEvento { get; set; }

    public string DescricaoEvento { get; set; }

    public DateOnly DataInicio { get; set; }

    public DateOnly DataTermino { get; set; }
}
