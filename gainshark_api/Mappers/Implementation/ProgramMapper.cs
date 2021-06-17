﻿using gainshark_api.Mappers.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using gainshark_api.Models;

namespace gainshark_api.Mappers.Implementation
{
	public class ProgramMapper : IMapper<Program>
	{
		public Program Map(MySqlDataReader dataReader)
		{
			Program program = new Program();

			program.Id = Convert.ToInt32(dataReader[0]);
			program.Name = dataReader[1] as string ?? null;
			program.Description = dataReader[2] as string ?? null;

			return program;
		}
	}
}