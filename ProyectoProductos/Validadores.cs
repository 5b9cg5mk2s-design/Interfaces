using System;

namespace ProyectoProductos
{
    // 1. EL CONTRATO (INTERFAZ)
    public interface IValidadorCampo
    {
        bool EsValido(string valor);
        string MensajeError { get; }
    }

    // 2. VALIDADOR PARA TEXTO (Nombre del producto)
    public class ValidadorTexto : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MensajeError = "El campo de texto no puede estar vacío.";
                return false;
            }
            return true;
        }
    }

    // 3. VALIDADOR PARA DECIMALES (Precio)
    public class ValidadorDecimal : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !decimal.TryParse(valor, out decimal resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un número decimal válido.";
                return false;
            }
            return true;
        }
    }

    // 4. VALIDADOR PARA ENTEROS (Cantidad)
    public class ValidadorEntero : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !int.TryParse(valor, out int resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un número entero válido.";
                return false;
            }
            return true;
        }
    }

    // 5. MODELO DE OBJETO PRODUCTO (Para guardar en la lista)
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
