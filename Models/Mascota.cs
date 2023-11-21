#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Tarea_Primera_Conexión_BD.Models;

public class Mascota {
    [Key]
    public int MascotaId { get; set; }
    public string Nombre { get; set; }
    public string TipoMascota { get; set; }
    public int Edad { get; set; }
    public bool TienePelo { get; set; }
    public DateTime Fecha_Creacion { get; set; }
    public DateTime Fecha_Modificacion { get; set; }

    public Mascota(){
        Fecha_Creacion = DateTime.Now;
        Fecha_Modificacion = DateTime.Now;
        FormatearFechas();
    }

    private void FormatearFechas()
    {
        string formatoChileno = "dd-MM-yyyy HH:mm:ss";
        Fecha_Creacion = DateTime.ParseExact(Fecha_Creacion.ToString(formatoChileno), formatoChileno, CultureInfo.InvariantCulture);
        Fecha_Modificacion = DateTime.ParseExact(Fecha_Modificacion.ToString(formatoChileno), formatoChileno, CultureInfo.InvariantCulture);
    }

}