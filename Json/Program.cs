using System;
/*RECEBER OS DADOS*/
using System.Net;
using System.IO;
/*tratar o dado recebido */
using Newtonsoft.Json;
/*PROGRAMA JSON "ESTAGIO PADAWANS"*/
namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {     /*MENU PRINCIPAL*/
            String opcao;
            do
            {

                Console.WriteLine("[Bem vindo ao menu principal]");
                Console.WriteLine("Voce pode acessar a Tela POST-----[1]");
                Console.WriteLine("Voce pode acessar a Tela Albums---[2]");
                Console.WriteLine("Voce pode acessar a Tela TODOS----[3]");
                Console.WriteLine("PARA SAIR DIGITE -----------------[0]");
                Console.Write("Digite a opcao desejada:");
                opcao = Console.ReadLine();
                Console.WriteLine("");
                /*MOSTRA A TELA DESEJADA */
                /*TELA POST*/
                if ("1" == opcao)
                {
                    string TEXTO;
                    string Tpost;
                    /*MENU POST */
                    do
                    {
                        Console.WriteLine("Bem vindo ao menu [POST]");
                        Console.WriteLine("Voce pode ver UM POST EXPECIFICO--------------* 1 A 100 *----[1]");
                        Console.WriteLine("Voce pode ver TODOS OS POST DE UNICO USUARIO--* 1 A 10 *-----[2]");
                        Console.WriteLine("Voce pode ver TODOS OS POST----------------------------------[3]");
                        Console.WriteLine("PARA VOLTAR DIGITE ------------------------------------------[0]");
                        Console.Write("Digite a opcao desejada:");
                        Tpost = Console.ReadLine();
                        Console.WriteLine("");

                        /*OPCAO [1] MOSTRA UM POST EXPECIFICO*/
                        if ("1" == Tpost)
                        {

                            /* POST QUE USUARIO DEJESA VISUALIZAR */
                            Console.WriteLine("Qual POST DESEJA VER : 1 A 100 ");
                            Console.Write("Digite:");
                            TEXTO = Console.ReadLine();
                            Console.WriteLine();
                            /*BUSCA O DADO jsonplaceholder.typicode.com/posts */
                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + TEXTO + "");
                            Json.Method = "GET";
                            Json.UserAgent = "RequisicaoWebDemo";
                            /*EXIBE O DADO SOLICITADO TRADADO PELO Newtonsoft.Json */
                            using (var resposta = Json.GetResponse())
                            {
                                var streamDados = resposta.GetResponseStream();
                                StreamReader reader = new StreamReader(streamDados);
                                object objResponse = reader.ReadToEnd();
                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                Console.WriteLine("PARA CONTINUAR PRECIONE A TECLA--[ENTER]" + "\n");
                                Console.ReadLine();
                                streamDados.Close();
                                resposta.Close();

                            }

                        }
                        /*OPCAO [2] RETORNA TODOS OS POST DE UM UNICO USUARIO*/
                        else if ("2" == Tpost)
                        {
                            /*IDENTIFICA QUAL USUARIO SOLICITADO*/
                            int X;
                            string User;
                            Console.WriteLine("OS POST DE QUAL USUARIO DESEJA VER: 1 A 10");
                            Console.Write("Digite USUARIO:");
                            User = Console.ReadLine();
                            Console.WriteLine("");
                            X = int.Parse(User);

                            /*BUSCA EM TODOS USUARIO QUAIS POST SÃO DO USUARIO SOLICITADO*/
                            for (int I = 1; I <= 100; I++)
                            {
                                switch (X)
                                {
                                    /*SELECIONA O USUARIO*/
                                    /*USUARO [1]*/
                                    case 1:
                                        if ((I >= 1) && (I <= 10))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [2]*/
                                    case 2:
                                        if ((I > 10) && (I <= 20))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [3]*/
                                    case 3:
                                        if ((I > 20) && (I <= 30))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [4]*/
                                    case 4:
                                        if ((I > 30) && (I <= 40))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [5]*/
                                    case 5:
                                        if ((I > 40) && (I <= 50))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [6]*/
                                    case 6:
                                        if ((I > 50) && (I <= 60))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [7]*/
                                    case 7:
                                        if ((I > 60) && (I <= 70))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [8]*/
                                    case 8:
                                        if ((I > 70) && (I <= 80))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [9]*/
                                    case 9:
                                        if ((I > 80) && (I <= 90))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [10]*/
                                    case 10:
                                        if ((I > 90) && (I <= 100))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "POST: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "Texto: " + post.Body + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;


                                }
                            }

                        }
                        /*OPCAO [3]RETORNA TODOS OS POST*/
                        else if ("3" == Tpost)
                        {
                            /*BUSCA O DADO DE TODOS OS POST*/
                            for (int I = 1; I <= 100; I++)
                            {


                                var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/posts/" + I + "");
                                Json.Method = "GET";
                                Json.UserAgent = "RequisicaoWebDemo";




                                using (var resposta = Json.GetResponse())
                                {


                                    var streamDados = resposta.GetResponseStream();
                                    StreamReader reader = new StreamReader(streamDados);
                                    object objResponse = reader.ReadToEnd();
                                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                    Console.WriteLine("Usuario: " + post.UserId + "\n");
                                    Console.WriteLine("POST: " + post.Id + "\n");
                                    Console.WriteLine("Titulo: " + post.Title + "\n");
                                    Console.WriteLine("Texto: " + post.Body + "\n");

                                    streamDados.Close();
                                    resposta.Close();


                                }
                            }
                        }
                    } while ("0" != Tpost);
                }
                /*TELA ALBUMS*/
                else if ("2" == opcao)
                {
                    /*MENU ALBUMS */
                    string TEXTO;
                    string Talbums;
                    do
                    {

                        Console.WriteLine("Bem vindo ao menu [ALBUMS]");
                        Console.WriteLine("Voce pode ver UM ALBUM EXPECIFICO----------------* 1 A 100 *-----[1]");
                        Console.WriteLine("Voce pode ver TODOS OS ALBUM DE UM UNICO USUARIO-* 1 A 10  *-----[2]");
                        Console.WriteLine("Voce pode ver TODOS OS ALBUM-------------------------------------[3]");
                        Console.WriteLine("PARA VOLTAR DIGITE ----------------------------------------------[0]");
                        Console.Write("Digite a opcao desejada:");
                        Talbums = Console.ReadLine();
                        Console.WriteLine();

                        /*OPCAO[1]*/
                        if ("1" == Talbums)
                        {


                            Console.WriteLine("QUAL ALBUM DESEJA VER");
                            Console.Write("Digite:");
                            TEXTO = Console.ReadLine();
                            Console.WriteLine("");
                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + TEXTO + "");
                            Json.Method = "GET";
                            Json.UserAgent = "RequisicaoWebDemo";

                            using (var resposta = Json.GetResponse())
                            {
                                var streamDados = resposta.GetResponseStream();
                                StreamReader reader = new StreamReader(streamDados);
                                object objResponse = reader.ReadToEnd();
                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                Console.WriteLine("Usuario: " + post.UserId + "\n");
                                Console.WriteLine("ALBUM: " + post.Id + "\n");
                                Console.WriteLine("Titulo: " + post.Title + "\n");
                                Console.WriteLine("PARA CONTINUAR PRECIONE A TECLA--[ENTER]" + "\n");
                                Console.ReadLine();
                                streamDados.Close();
                                resposta.Close();

                            }


                        }
                        /*OPCAO[2]*/
                        else if ("2" == Talbums)
                        {
                            /*SOLICITA QUAL ALBUM DESEJADO*/
                            int X;
                            string User;
                            Console.WriteLine("OS ALBUMS DE QUAL USUARIO DESEJA VER");
                            Console.Write("Digite:");
                            User = Console.ReadLine();
                            Console.WriteLine("");
                            X = int.Parse(User);

                            /*BUSCA EM TODOS USUARIO QUAIS ALBUMS SÃO DO USUARIO SOLICITADO*/
                            for (int I = 1; I <= 100; I++)
                            {
                                /*SELECIONA O USUARIO*/


                                switch (X)
                                {

                                    /*USUARO [1]*/
                                    case 1:
                                        if ((I >= 1) && (I <= 10))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [2]*/
                                    case 2:
                                        if ((I > 10) && (I <= 20))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [3]*/
                                    case 3:
                                        if ((I > 20) && (I <= 30))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [4]*/
                                    case 4:
                                        if ((I > 30) && (I <= 40))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [5]*/
                                    case 5:
                                        if ((I > 40) && (I <= 50))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [6]*/
                                    case 6:
                                        if ((I > 50) && (I <= 60))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [7]*/
                                    case 7:
                                        if ((I > 60) && (I <= 70))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [8]*/
                                    case 8:
                                        if ((I > 70) && (I <= 80))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [9]*/
                                    case 9:
                                        if ((I > 80) && (I <= 90))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [10]*/
                                    case 10:
                                        if ((I > 90) && (I <= 100))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n\n" + "Album: " + post.Id + "\n\n" + "Titulo: " + post.Title + "\n\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;


                                }

                            }

                        }
                        else if ("3" == Talbums)
                        {

                            for (int I = 1; I <= 100; I++)
                            {


                                var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/albums/" + I + "");
                                Json.Method = "GET";
                                Json.UserAgent = "RequisicaoWebDemo";




                                using (var resposta = Json.GetResponse())
                                {


                                    var streamDados = resposta.GetResponseStream();
                                    StreamReader reader = new StreamReader(streamDados);
                                    object objResponse = reader.ReadToEnd();
                                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                    Console.WriteLine("Usuario: " + post.UserId + "\n");
                                    Console.WriteLine("POST: " + post.Id + "\n");
                                    Console.WriteLine("Titulo: " + post.Title + "\n");
                                    Console.WriteLine("Texto: " + post.Body + "\n");

                                    streamDados.Close();
                                    resposta.Close();


                                }
                            }
                        }
                    } while ("0" != Talbums);


                }
                /*TELA TODOS*/
                else if ("3" == opcao)
                {

                    string TEXTO;
                    string TODOS;
                    /*MENU TODOS */
                    do
                    {
                        Console.WriteLine("Bem vindo ao menu [TODOS]");
                        Console.WriteLine("Voce pode ver UMA TABELA TODOS EXPECIFICA--------------------* 1 A 200 *----[1]");
                        Console.WriteLine("Voce pode ver TELA TODOS DE UNICO USUARIO--------------------* 1 A 10  *----[2]");
                        Console.WriteLine("Voce pode ver TODOS OS USUARIOS---------------------------------------------[3]");
                        Console.WriteLine("PARA VOLTAR DIGITE ---------------------------------------------------------[0]");
                        Console.Write("Digite a opcao desejada:");
                        TODOS = Console.ReadLine();
                        Console.WriteLine("");

                        /*OPCAO [1] MOSTRA U EXPECIFICO*/
                        if ("1" == TODOS)
                        {

                            /* POST QUE USUARIO DEJESA VISUALIZAR */
                            Console.WriteLine("Qual IMFORMACAO DA TELA TODOS DESEJA VER : 1 A 200 ");
                            Console.Write("Digite:");
                            TEXTO = Console.ReadLine();
                            Console.WriteLine();
                            /*BUSCA O DADO jsonplaceholder.typicode.com/posts */
                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + TEXTO + "");
                            Json.Method = "GET";
                            Json.UserAgent = "RequisicaoWebDemo";
                            /*EXIBE O DADO SOLICITADO TRADADO PELO Newtonsoft.Json */
                            using (var resposta = Json.GetResponse())
                            {
                                var streamDados = resposta.GetResponseStream();
                                StreamReader reader = new StreamReader(streamDados);
                                object objResponse = reader.ReadToEnd();
                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                Console.WriteLine("PARA CONTINUAR PRECIONE A TECLA--[ENTER]" + "\n");
                                Console.ReadLine();
                                streamDados.Close();
                                resposta.Close();

                            }

                        }
                        /*OPCAO [2] RETORNA TELA TODOS DE  UNICO USUARIO*/
                        else if ("2" == TODOS)
                        {
                            /*IDENTIFICA QUAL USUARIO SOLICITADO*/
                            int X;
                            string User;
                            Console.WriteLine("DE QUAL USUARIO DESEJA VER: 1 A 10");
                            Console.Write("Digite USUARIO:");
                            User = Console.ReadLine();
                            Console.WriteLine("");
                            X = int.Parse(User);

                            /*BUSCA QUAIS DADOS SÃO DO USUARIO SOLICITADO*/
                            for (int I = 1; I <= 200; I++)
                            {
                                switch (X)
                                {
                                    /*SELECIONA O USUARIO*/
                                    /*USUARO [1]*/
                                    case 1:
                                        if ((I >= 1) && (I <= 20))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [2]*/
                                    case 2:
                                        if ((I > 20) && (I <= 40))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [3]*/
                                    case 3:
                                        if ((I > 40) && (I <= 60))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [4]*/
                                    case 4:
                                        if ((I > 60) && (I <= 80))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [5]*/
                                    case 5:
                                        if ((I > 80) && (I <= 100))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [6]*/
                                    case 6:
                                        if ((I > 100) && (I <= 120))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [7]*/
                                    case 7:
                                        if ((I > 120) && (I <= 140))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [8]*/
                                    case 8:
                                        if ((I > 140) && (I <= 160))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [9]*/
                                    case 9:
                                        if ((I > 160) && (I <= 180))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;
                                    /*USUARO [10]*/
                                    case 10:
                                        if ((I > 180) && (I <= 200))
                                        {


                                            var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I);
                                            Json.Method = "GET";
                                            Json.UserAgent = "RequisicaoWebDemo";


                                            using (var resposta = Json.GetResponse())
                                            {


                                                var streamDados = resposta.GetResponseStream();
                                                StreamReader reader = new StreamReader(streamDados);
                                                object objResponse = reader.ReadToEnd();
                                                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                                Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                                streamDados.Close();
                                                resposta.Close();

                                            }


                                        }
                                        break;


                                }
                            }

                        }
                        /*OPCAO [3]RETORNA TODOS */
                        else if ("3" == TODOS)
                        {
                            /*BUSCA O DADO DE TODOS */
                            for (int I = 1; I <= 100; I++)
                            {


                                var Json = WebRequest.CreateHttp("http://jsonplaceholder.typicode.com/todos/" + I + "");
                                Json.Method = "GET";
                                Json.UserAgent = "RequisicaoWebDemo";




                                using (var resposta = Json.GetResponse())
                                {


                                    var streamDados = resposta.GetResponseStream();
                                    StreamReader reader = new StreamReader(streamDados);
                                    object objResponse = reader.ReadToEnd();
                                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                                    Console.WriteLine("Usuario: " + post.UserId + "\n" + "ID: " + post.Id + "\n" + "Titulo: " + post.Title + "\n" + "COMPLETO: " + post.Completed + "\n");
                                    streamDados.Close();
                                    resposta.Close();


                                }
                            }
                        }
                    } while ("0" != TODOS);


                }


            } while ("0" != opcao);

        }
    }
}
