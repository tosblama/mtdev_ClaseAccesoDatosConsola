using ClaseAccesoDatos_Consola;
using System.Data.SqlClient;

AccesoDatos.cadenaConexion = "Data Source=W11-EPV;Initial Catalog=EPV;Integrated Security=true;";
string jsonResultado;

Console.Clear();

// Ejecutar consulta SQL y obtener resultados en formato JSON
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Pulsa intro para ejecutar una consulta SQL y obtener los resultados en formato JSON");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Blue;
jsonResultado = await AccesoDatos.JsonDataReader("SELECT * FROM dbo.Provincias WHERE IdUsuario<=5");
Console.WriteLine(jsonResultado);
Console.WriteLine("\n\n");

// Llamar a procedimiento almacenado y mostrar resultados en formato JSON
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Pulsa intro para ejecutar un procedimiento almacenado y obtener los resultados en formato JSON");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Blue;
List<SqlParameter> SqlParams = new List<SqlParameter>();
SqlParameter p;
p = new SqlParameter(); p.ParameterName = "Sumando1"; p.SqlDbType = System.Data.SqlDbType.Int; p.SqlValue = 4; SqlParams.Add(p);
p = new SqlParameter(); p.ParameterName = "Sumando2"; p.SqlDbType = System.Data.SqlDbType.Int; p.SqlValue = 5; SqlParams.Add(p);
p = new SqlParameter(); p.ParameterName = "Resultado"; p.SqlDbType = System.Data.SqlDbType.Int; p.Direction = System.Data.ParameterDirection.Output; SqlParams.Add(p);
jsonResultado = await AccesoDatos.JsonStoredProcedure("dbo.spSumar", SqlParams.ToArray());
Console.WriteLine(jsonResultado);
Console.WriteLine("\n\n");

// Llamar a procedimiento almacenado que devuelve tabla y mostrar resultados en formato JSON
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Pulsa intro para ejecutar un procedimiento almacenado y obtener los resultados en formato JSON");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Blue;
SqlParams = new List<SqlParameter>();
p = new SqlParameter(); p.ParameterName = "Sumando1"; p.SqlDbType = System.Data.SqlDbType.Int; p.SqlValue = 4; SqlParams.Add(p);
p = new SqlParameter(); p.ParameterName = "Sumando2"; p.SqlDbType = System.Data.SqlDbType.Int; p.SqlValue = 5; SqlParams.Add(p);
p = new SqlParameter(); p.ParameterName = "Resultado"; p.SqlDbType = System.Data.SqlDbType.Int; p.Direction = System.Data.ParameterDirection.Output; SqlParams.Add(p);
jsonResultado = await AccesoDatos.JsonStoredProcedure("dbo.spSumarConTabla", SqlParams.ToArray());
Console.WriteLine(jsonResultado);
Console.WriteLine("\n\n");

// Finalizar
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Pulsa intro para finalizar");
Console.ReadLine();


