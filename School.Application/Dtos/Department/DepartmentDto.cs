using System;
using System.ComponentModel.DataAnnotations;
using School.Application.Dtos;

namespace School.Application.Dtos.Department
{
    public class DepartmentDto : DtoBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(250, ErrorMessage = "La descripción no puede superar los 250 caracteres.")]
        public string Description { get; set; }
    }
}


