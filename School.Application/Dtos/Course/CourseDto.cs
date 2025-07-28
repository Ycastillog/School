using System;
using System.ComponentModel.DataAnnotations;
using School.Application.Dtos;

namespace School.Application.Dtos.Course
{
    public class CourseDto : DtoBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Los créditos son obligatorios.")]
        [Range(1, 10, ErrorMessage = "Los créditos deben estar entre 1 y 10.")]
        public int Credits { get; set; }
    }
}


