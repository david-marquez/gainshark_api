﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity;

namespace gainshark_api.Unity
{
	public class UnityResolver : IDependencyResolver
	{
		private readonly IUnityContainer _container;

		public UnityResolver(IUnityContainer container)
		{
			_container = container;
		}

		public IDependencyScope BeginScope()
		{
			var child = _container.CreateChildContainer();
			return new UnityResolver(child);
		}

		public void Dispose()
		{
				_container.Dispose();
		}

		public object GetService(Type serviceType)
		{
			try
			{
				return _container.Resolve(serviceType);
			}
			catch(ResolutionFailedException)
			{
				return null;
			}
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			try
			{
				return _container.ResolveAll(serviceType);
			}
			catch(ResolutionFailedException)
			{
				return null;
			}
		}
	}
}