using Marsman.UmbracoCodeFirst.Attributes;
using System;
using System.Collections.Generic;

namespace Marsman.UmbracoCodeFirst.Core.Modules
{
    public class MediaTypeRegistration : ContentTypeRegistration
    {
        public MediaTypeRegistration(IEnumerable<PropertyRegistration> properties, IEnumerable<TabRegistration> tabs, IEnumerable<ContentTypeCompositionRegistration> compositions, string alias, string name, Type clrType, MediaTypeAttribute mediaTypeAttribute)
            : base(properties, tabs, compositions, alias, name, clrType, mediaTypeAttribute) { }

        public MediaTypeAttribute MediaTypeAttribute
        {
            get
            {
                return ContentTypeAttribute as MediaTypeAttribute;
            }
            set
            {
                ContentTypeAttribute = value;
            }
        }
    }
}