﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gainshark_api.Repositories.Contract
{
	public interface IRepository<T> where T : class
	{
		void AddItem(T item);
		void DeleteItem(int id);
		T GetItem(int id);
		IList<T> GetItems();
		void UpdateItem(T item);
	}
}
