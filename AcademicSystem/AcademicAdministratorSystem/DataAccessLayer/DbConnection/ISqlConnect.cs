﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
    public  interface ISqlConnect
    {
        SqlConnection GetConnection();
    }
}
