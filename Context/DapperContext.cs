using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ControlEscolar.Context
{
  public class DapperContext
  {
    private readonly IConfiguration _configuration;
    private readonly string _connectionLocal;

    public DapperContext(IConfiguration configuration)
    {
      _configuration = configuration;
      _connectionLocal = _configuration.GetConnectionString("LocalConnection");
    }
    
    public IDbConnection CreateConnectionLocal() => new SqlConnection(_configuration.GetConnectionString("LocalConnection"));
  }
}