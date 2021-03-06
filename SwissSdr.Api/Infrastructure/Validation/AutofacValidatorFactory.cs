﻿using Autofac;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwissSdr.Api.Infrastructure
{
	public class AutofacValidatorFactory : ValidatorFactoryBase
	{
		private readonly IComponentContext _context;

		public AutofacValidatorFactory(IComponentContext context)
		{
			_context = context;
		}

		public override IValidator CreateInstance(Type validatorType)
		{
			object instance = null;
			_context.TryResolve(validatorType, out instance);
			return instance as IValidator;
		}
	}
}
