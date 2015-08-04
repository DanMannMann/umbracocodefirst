using Felinesoft.UmbracoCodeFirst;
using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;
using Felinesoft.UmbracoCodeFirst.ContentTypes;
using System.Web;
using Felinesoft.UmbracoCodeFirst.Core;

namespace Felinesoft.UmbracoCodeFirst.ContentTypes
{
    [MediaType("Image", "Image", null, "icon-picture", false, false, "", "codefirst codefirst-image")]
    [BuiltInMediaType]
    public class MediaImage : MediaImageBase
    {

    }

    public class MediaImageBase : MediaTypeBase, IHtmlString
    {
        public class ImageTab : TabBase
        {
            [ContentProperty("Upload image", "umbracoFile", false, "", 0, false)]
            public Upload UploadImage { get; set; }

            [ContentProperty("Width", "umbracoWidth", false, "", 1, false)]
            public Label Width { get; set; }

            [ContentProperty("Height", "umbracoHeight", false, "", 2, false)]
            public Label Height { get; set; }

            [ContentProperty("Size", "umbracoBytes", false, "", 3, false)]
            public Label Size { get; set; }

            [ContentProperty("Type", "umbracoExtension", false, "", 4, false)]
            public Label Type { get; set; }
        }

        [ContentTab("Image", 1)]
        public ImageTab Image { get; set; }

        public string ToHtmlString()
        {
            var css = DataTypeUtils.GetHtmlClassAttribute(this);
            return Image == null || Image.UploadImage == null ? string.Empty : "<img" + css + " src='" + Image.UploadImage.Url + "' alt='" + NodeDetails.Name + "' />";
        }

        public override string ToString()
        {
            return Image == null || Image.UploadImage == null ? string.Empty : Image.UploadImage.Url;
        }
    }
}