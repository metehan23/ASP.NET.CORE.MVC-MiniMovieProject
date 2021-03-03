using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMovieApp.Models;

namespace MiniMovieApp.Data
{
    public static class CategorRepository
    {
        private static List<Category> _categories = null;
        static CategorRepository()
        {
            _categories = new List<Category>()
            {
              new Category() {Id=1,Name="Aksiyon"},
              new Category() {Id=2,Name="Bilim Kurgu"},
              new Category() {Id=3,Name="Dram"},
              new Category() {Id=4,Name="Romantik"},
              new Category() {Id=5,Name="Komedi"}
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}

