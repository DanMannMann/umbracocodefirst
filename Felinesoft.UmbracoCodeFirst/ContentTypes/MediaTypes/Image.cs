using Marsman.UmbracoCodeFirst;
using Marsman.UmbracoCodeFirst.DataTypes;
using Marsman.UmbracoCodeFirst.Attributes;
using Marsman.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Marsman.UmbracoCodeFirst.DataTypes.BuiltIn;
using Marsman.UmbracoCodeFirst.ContentTypes;
using System.Web;
using Marsman.UmbracoCodeFirst.Core;

namespace Marsman.UmbracoCodeFirst.ContentTypes
{
    [MediaType("Image", "Image", null, "icon-picture", true, false, null)]
    [BuiltInMediaType]
    public class MediaImage : MediaImageBase
    {

    }

    [CodeFirstCommonBase]
    public class MediaImageBase : MediaTypeBase, IHtmlString
    {
        public class ImageTab : TabBase
        {
            [ContentProperty("Upload image", "umbracoFile", false, "", 0, false)]
			public ImageCropper UploadImage { get; set; }

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
            var toAdd = DataTypeUtils.GetHtmlTagContentFromContextualAttributes(this);
            return Image == null || Image.UploadImage == null ? string.Empty : "<img" + toAdd + " src='" + Image.UploadImage.OriginalImageUrl + "' />";
        }

        public override string ToString()
        {
            return Image == null || Image.UploadImage == null ? string.Empty : Image.UploadImage.OriginalImageUrl;
        }
    }
}