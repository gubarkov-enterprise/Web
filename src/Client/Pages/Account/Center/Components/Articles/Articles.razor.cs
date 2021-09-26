using System.Collections.Generic;
using Web.Models;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}