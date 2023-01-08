using System.Data;
using ControlEscolar.Context;
using ControlEscolar.Contracts;
using ControlEscolar.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControlEscolar.Repository
{
    public class AlumnoRepository : IAlumno
    {

        private readonly DapperContext _context;
        public AlumnoRepository(DapperContext context)
        {
            _context = context;
        }


       
        public List<Alumno> ConsultaAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            using(IDbConnection connection = _context.CreateConnectionLocal() )
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT * FROM Alumnos";

                alumnos = connection.Query<Alumno>(query).ToList();
            }
            
                return alumnos;
        }

        public List<Alumno> ConsultaAlumno(int id)
        {
            Alumno alumno = new Alumno();

            using(IDbConnection connection = _context.CreateConnectionLocal())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = $@"SELECT * FROM Alumnos WERE Id_Alumno = {id}";

                alumno = connection.Query<Alumno>(query).FirstOrDefault();
            }

            return alumno;
        }
    }
}