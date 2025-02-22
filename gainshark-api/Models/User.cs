﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gainshark_api.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public Role Role { get; set; }
		public IList<Program> Programs { get; set; }
	}
}