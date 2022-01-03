using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Descripción breve de Connection
/// </summary>
public sealed class Connection
{
    private const string database = "miConexion";
    public string connectionString;

    public string ConnectionString
    {
        get
        {
            return this.connectionString;
        }
        private set
        {
            this.connectionString = value;
        }
    }

    public Connection()
    {
        this.ConnectionString = WebConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
    }
}