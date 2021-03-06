using System;
using System.Linq;
using System.Collections.Generic;
using Marsman.UmbracoCodeFirst.ContentTypes;
using Marsman.UmbracoCodeFirst.Core.Resolver;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace Marsman.UmbracoCodeFirst.Seeding
{
	public sealed class MediaSeed : Seed<MediaTypeBase>
	{
		internal MediaSeed(string nodeName, MediaTypeBase media, IEnumerable<MediaSeed> children)
			: base(nodeName, media)
		{
			Children = children;
		}

		public IEnumerable<MediaSeed> Children { get; private set; }
	}
}