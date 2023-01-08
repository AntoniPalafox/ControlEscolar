namespace ControlEscolar.Models
{
    public class Alumno
    {
        
        
        public int Id_Alumno { get; set; }
        public string? D_Nombre { get; set; }
        public string? D_Ap_Paterno { get; set; }
        public string? D_Ap_Materno { get; set; }
        public DateTime? F_Nacimiento { get; set; }
        public string? Curp { get; set; }
        public string? Rfc { get; set; }
        public string? Nss { get; set; }
    }
}