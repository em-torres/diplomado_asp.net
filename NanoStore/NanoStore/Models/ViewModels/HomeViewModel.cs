using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NanoStore.Models.RawSql;

namespace NanoStore.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Producto> Productos { get; set; }
        public IEnumerable<CategoriasContadorRQ> CategoriasContador { get; set; }
    }
}