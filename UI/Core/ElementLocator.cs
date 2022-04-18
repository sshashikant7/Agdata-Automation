using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Core
{
    /// <summary>
    /// Element Locator Stratergy 
    /// </summary>
    public enum ElementLocator
    {
        ID,
        Name,
        CssSelector,
        LinkText,
        PartialLinkText,
        Xpath,
        ClassName,
        TagName
    }
}
