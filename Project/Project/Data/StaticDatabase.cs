using Project.Models;

namespace Project.Data;

public class StaticDatabase
{
    public static List<Prodotto> Prodotti = new List<Prodotto>()
    {
        new Prodotto()
        {
            Id = 1,
            Nome = "Air Force 1",
            Prezzo = 110,
            Descrizione = "Le scarpe adatte a tutto.",
            Copertina =
                "https://www.shoebuya.com/cdn/shop/products/image_b336e494-2fbb-4e14-b725-82afda63f27c.webp?v=1671897932&width=1024",
            ImmaginiAggiuntive = new List<string>
            {
                "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
                "https://img01.ztat.net/article/spp-media-p1/f32344dbb13b4e1c855ce627f239e77a/8b6311fa655445e7a40bb4c2bfdf932b.jpg?imwidth=762&filter=packshot"
            }
        },
        new Prodotto()
        {
            Id = 2,
            Nome = "Jordan 1",
            Prezzo = 340,
            Descrizione = "Scarpe sportive desiderate da tutti per via della loro controversa storia",
            Copertina =
                "https://images.stockx.com/images/Air-Jordan-1-SB-Light-Bone-Black-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&fm=webp&auto=compress&q=90&dpr=2&trim=color&updated_at=1738193358",
            ImmaginiAggiuntive = new List<string>
            {
                "https://i.ebayimg.com/images/g/BtkAAOSwR9Zh3bsQ/s-l1200.jpg",
                "https://www.waitfashion.com/wp-content/uploads/2020/04/1559227553hA9Sr_-1.jpg"
            }
        },
        new Prodotto()
        {
            Id = 3,
            Nome = "Jordan 5",
            Prezzo = 270,
            Descrizione = "Scarpa di nicchia, amata dai collezionisti",
            Copertina =
                "https://static.nike.com/a/images/w_1280,q_auto,f_auto/49bd38a1-f3a3-478b-867a-b79c775a0d4c/air-jordan-5-racer-blue-ct4838-004-data-del-lancio.jpg",
            ImmaginiAggiuntive = new List<string>
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdjtS3kf4Qy_HRFKMKLIrDyVxRR1tQkubPMg&s",
                "https://cdn.sanity.io/images/pu5wtzfc/production/3d27668d9eb978296a0f0fc59643bd616411f7de-1200x1063.jpg"
            }
        }
    };
}