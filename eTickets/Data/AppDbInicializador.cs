using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInicializador
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Nome = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Descricao = "This is the Description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nome = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Descricao = "This is the Description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nome = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Descricao = "This is the Description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nome = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Descricao = "This is the Description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nome = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Descricao = "This is the Description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Atores
                if (!context.Atores.Any())
                {
                    context.Atores.AddRange(new List<Ator>()
                    {
                        new Ator()
                        {
                            NomeCompleto = "Ator 1",
                            Bio = "This is the Bio of the first Ator",
                            FotoDePerfilURL = "http://dotnethow.net/images/Atores/Ator-1.jpeg"

                        },
                        new Ator()
                        {
                            NomeCompleto = "Ator 2",
                            Bio = "This is the Bio of the second Ator",
                            FotoDePerfilURL = "http://dotnethow.net/images/Atores/Ator-2.jpeg"
                        },
                        new Ator()
                        {
                            NomeCompleto = "Ator 3",
                            Bio = "This is the Bio of the second Ator",
                            FotoDePerfilURL = "http://dotnethow.net/images/Atores/Ator-3.jpeg"
                        },
                        new Ator()
                        {
                            NomeCompleto = "Ator 4",
                            Bio = "This is the Bio of the second Ator",
                            FotoDePerfilURL = "http://dotnethow.net/images/Atores/Ator-4.jpeg"
                        },
                        new Ator()
                        {
                            NomeCompleto = "Ator 5",
                            Bio = "This is the Bio of the second Ator",
                            FotoDePerfilURL = "http://dotnethow.net/images/Atores/Ator-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Produtores
                if (!context.Produtores.Any())
                {
                    context.Produtores.AddRange(new List<Produtor>()
                    {
                        new Produtor()
                        {
                            NomeCompleto = "Produtor 1",
                            Bio = "This is the Bio of the first actor",
                            FotoDePerfilURL = "http://dotnethow.net/images/Produtores/Produtor-1.jpeg"

                        },
                        new Produtor()
                        {
                            NomeCompleto = "Produtor 2",
                            Bio = "This is the Bio of the second actor",
                            FotoDePerfilURL = "http://dotnethow.net/images/Produtores/Produtor-2.jpeg"
                        },
                        new Produtor()
                        {
                            NomeCompleto = "Produtor 3",
                            Bio = "This is the Bio of the second actor",
                            FotoDePerfilURL = "http://dotnethow.net/images/Produtores/Produtor-3.jpeg"
                        },
                        new Produtor()
                        {
                            NomeCompleto = "Produtor 4",
                            Bio = "This is the Bio of the second actor",
                            FotoDePerfilURL = "http://dotnethow.net/images/Produtores/Produtor-4.jpeg"
                        },
                        new Produtor()
                        {
                            NomeCompleto = "Produtor 5",
                            Bio = "This is the Bio of the second actor",
                            FotoDePerfilURL = "http://dotnethow.net/images/Produtores/Produtor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Filmes
                if (!context.Filmes.Any())
                {
                    context.Filmes.AddRange(new List<Filme>()
                    {
                        new Filme()
                        {
                            Nome = "Life",
                            Descricao = "This is the Life Filme Descricao",
                            Preco = 39.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-3.jpeg",
                            DataInicio = DateTime.Now.AddDays(-10),
                            DataFim = DateTime.Now.AddDays(10),
                            IdCinema = 3,
                            IdProdutor = 3,
                            CategoriaFilme = CategoriaFilme.Documentário
                        },
                        new Filme()
                        {
                            Nome = "The Shawshank Redemption",
                            Descricao = "This is the Shawshank Redemption Descricao",
                            Preco = 29.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-1.jpeg",
                            DataInicio = DateTime.Now,
                            DataFim = DateTime.Now.AddDays(3),
                            IdCinema = 1,
                            IdProdutor = 1,
                            CategoriaFilme = CategoriaFilme.Ação
                        },
                        new Filme()
                        {
                            Nome = "Ghost",
                            Descricao = "This is the Ghost Filme Descricao",
                            Preco = 39.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-4.jpeg",
                            DataInicio = DateTime.Now,
                            DataFim = DateTime.Now.AddDays(7),
                            IdCinema = 4,
                            IdProdutor = 4,
                            CategoriaFilme = CategoriaFilme.Terror
                        },
                        new Filme()
                        {
                            Nome = "Race",
                            Descricao = "This is the Race Filme Descricao",
                            Preco = 39.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-6.jpeg",
                            DataInicio = DateTime.Now.AddDays(-10),
                            DataFim = DateTime.Now.AddDays(-5),
                            IdCinema = 1,
                            IdProdutor = 2,
                            CategoriaFilme = CategoriaFilme.Documentário
                        },
                        new Filme()
                        {
                            Nome = "Scoob",
                            Descricao = "This is the Scoob Filme Descricao",
                            Preco = 39.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-7.jpeg",
                            DataInicio = DateTime.Now.AddDays(-10),
                            DataFim = DateTime.Now.AddDays(-2),
                            IdCinema = 1,
                            IdProdutor = 3,
                            CategoriaFilme = CategoriaFilme.Desenho
                        },
                        new Filme()
                        {
                            Nome = "Cold Soles",
                            Descricao = "This is the Cold Soles Filme Descricao",
                            Preco = 39.50,
                            ImagemURL = "http://dotnethow.net/images/Filmes/Filme-8.jpeg",
                            DataInicio = DateTime.Now.AddDays(3),
                            DataFim = DateTime.Now.AddDays(20),
                            IdCinema = 1,
                            IdProdutor = 5,
                            CategoriaFilme = CategoriaFilme.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Atores & Filmes
                if (!context.Atores_Filmes.Any())
                {
                    context.Atores_Filmes.AddRange(new List<Ator_Filme>()
                    {
                        new Ator_Filme()
                        {
                            IdAtor = 1,
                            IdFilme = 1
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 3,
                            IdFilme = 1
                        },

                         new Ator_Filme()
                        {
                            IdAtor = 1,
                            IdFilme = 2
                        },
                         new Ator_Filme()
                        {
                            IdAtor = 4,
                            IdFilme = 2
                        },

                        new Ator_Filme()
                        {
                            IdAtor = 1,
                            IdFilme = 3
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 2,
                            IdFilme = 3
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 5,
                            IdFilme = 3
                        },


                        new Ator_Filme()
                        {
                            IdAtor = 2,
                            IdFilme = 4
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 3,
                            IdFilme = 4
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 4,
                            IdFilme = 4
                        },


                        new Ator_Filme()
                        {
                            IdAtor = 2,
                            IdFilme = 5
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 3,
                            IdFilme = 5
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 4,
                            IdFilme = 5
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 5,
                            IdFilme = 5
                        },


                        new Ator_Filme()
                        {
                            IdAtor = 3,
                            IdFilme = 6
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 4,
                            IdFilme = 6
                        },
                        new Ator_Filme()
                        {
                            IdAtor = 5,
                            IdFilme = 6
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
