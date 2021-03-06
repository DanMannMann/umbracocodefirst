﻿using Marsman.UmbracoCodeFirst.Core.Resolver;
using Marsman.UmbracoCodeFirst.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Marsman.UmbracoCodeFirst.Core.Modules
{
    public interface IDocumentTypeModule : IContentTypeModuleBase, ICodeFirstEntityModule
    {
        bool TryGetDocumentType(string alias, out DocumentTypeRegistration registration);
        bool TryGetDocumentType(Type type, out DocumentTypeRegistration registration);
        bool TryGetDocumentType<T>(out DocumentTypeRegistration registration) where T : DocumentTypeBase;
		DocumentTypeRegistration GetDocumentType<T>() where T : DocumentTypeBase;
		DocumentTypeRegistration GetDocumentType(Type type);
		DocumentTypeRegistration GetDocumentType(string alias);
	}
}
