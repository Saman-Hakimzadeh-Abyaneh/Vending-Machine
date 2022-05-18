using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetAll();
    }
}