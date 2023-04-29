using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Backend_CRUD.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre
        {
            get => _nombre;
            set
            {
                if (value != null)
                {
                    Regex regex = new Regex("^[a-zA-Z]+$");
                    if (!regex.IsMatch(value))
                    {
                        throw new ArgumentException("El campo Nombre solo debe contener letras.");
                    }
                }
                _nombre = value;
            }
        }

        private string? _nombre;
        public string? Estatus { get; set; }
    }
}
