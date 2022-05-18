using System.Collections.Generic;

namespace Domain.Models
{
    public class Recipe
    {
        public string Description { set; get; }
        public string ImagePath { set; get; }
        public List<ActionsEnum> Actions { set; get; }
    }
}