
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            { new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce built on ASP.NET Core",
                Link = "https://www.amazon.com",
                ImagenURL = "/image/amazon.png"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Social network to share in communities",
                Link = "https://www.reddit.com",
                ImagenURL = "/image/reddit.png"
            },
            new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "News Pages",
                Link = "https://www.nyt.com",
                ImagenURL = "/image/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Online Store for the sale of Video Games",
                Link = "https://www.steam.com",
                ImagenURL = "/image/steam.png"
            },
            };
        }

    }
}
