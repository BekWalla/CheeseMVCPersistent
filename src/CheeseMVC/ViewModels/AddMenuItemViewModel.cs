using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int cheeseID { get; set; }
        public int menuID { get; set; }
        public Menu menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }


        public AddMenuItemViewModel()
        {


        }

        public AddMenuItemViewModel(Menu chzmenu, IEnumerable<Cheese> cheese)
        {
            Cheeses = new List<SelectListItem>();
            menu = chzmenu;
            foreach (Cheese cheez in cheese)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheez.ID.ToString(),
                    Text = cheez.Name

                });


            }


        }

    }
}
