using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Controllers;

public class ProdottoController : Controller
{
    public IActionResult Index()
    {
        var prodotti = StaticDatabase.Prodotti;
        return View(prodotti);
    }

    public IActionResult Dettaglio(int id)
    {
        var prodotto = StaticDatabase.Prodotti.FirstOrDefault(p => p.Id == id);
        if (prodotto == null)
        {
            return NotFound(); 
        }

        return View(prodotto);
    }
}