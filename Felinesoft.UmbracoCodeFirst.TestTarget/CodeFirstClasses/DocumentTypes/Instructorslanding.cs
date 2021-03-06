using Marsman.UmbracoCodeFirst;
using Marsman.UmbracoCodeFirst.ContentTypes;
using Marsman.UmbracoCodeFirst.DataTypes;
using Marsman.UmbracoCodeFirst.Attributes;
using Marsman.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Marsman.UmbracoCodeFirst.DataTypes.BuiltIn;

namespace LMI.BusinessLogic.CodeFirst
{
    [DocumentType(@"Instructors Landing", @"InstructorsLanding", new Type[] { typeof(Modules), typeof(Articletopic), typeof(Webpage), typeof(Redirectpage), typeof(Events) }, @"icon-operator", false, false, @"")]
    [Template(true, "Webpage", "Webpage")]
    public class Instructorslanding : Seopage
    {
        public class MenuTab : TabBase
        {
            [ContentProperty(@"Has Flyout Menu", @"hasFlyoutMenu", false, @"Tick this if this is a main menu link with flyout menu", 0, false)]
            public Checkbox Hasflyoutmenu { get; set; }

            [ContentProperty(@"Show in Flyout Menu", @"showInFlyoutMenu", false, @"Tick this if you want this page to appear as a child in a flyout menu", 1, false)]
            public Checkbox Showinflyoutmenu { get; set; }

            [ContentProperty(@"Hide In Sub Nav", @"hideInSubNav", false, @"Hide this from sub navigation", 2, false)]
            public Checkbox Hideinsubnav { get; set; }

        }

        [ContentTab(@"Menu", 0)]
        public MenuTab Menu { get; set; }
    }
}