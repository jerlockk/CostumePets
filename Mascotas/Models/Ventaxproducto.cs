namespace Mascotas.Models
{
    public class Ventaxproducto
    {
        public long Id { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        public Producto Producto { get; set; }

    }
}