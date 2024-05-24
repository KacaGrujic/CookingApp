
using Common;
using Common.Communication;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private readonly Socket socket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal void HandleRequest()
        {
            try
            {

                while (true)
                {
                    Request r = receiver.Receive<Request>();
                    Response response = HandleRequest(r);
                    sender.Send(response);
                }
            }
            catch (SocketException ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                Server.Instance.clients.Remove(this);
            }
        }

        public void Close()
        {
            socket.Close();
            
        }


        Korisnik korisnik;

        private Response HandleRequest(Request r)
        {

            Response response = new Response();
            try
            {
                try
                {
                    response.IsSuccessfull = true;
                    switch (r.Operation)
                    {
                        case Operation.Login:
                            korisnik = (Korisnik)Controller.Instance.Login((Korisnik)r.Argument);
                            if (korisnik != null)
                            {
                                if (!Server.ulogovani.Contains(korisnik))
                                {
                                    response.Result = korisnik;
                                    response.Message = "Uspesna prijava na sistem";
                                    response.IsSuccessfull = true;
                                    Server.ulogovani.Add(korisnik);
                                    Console.WriteLine("Id ulogovanog korisnika : " + korisnik.KorisnikID);
                                }
                                else
                                {
                                    response.IsSuccessfull = false;
                                    response.Message = "Neuspesno prijavljivanje na sistem!";
                                }

                            }
                            else
                            {
                                response.IsSuccessfull = false;
                                response.Message = "Neuspesno prijavljivanje na sistem!";
                            }

                            break;
                        case Operation.VratiNamirnice:
                            response.Result = Controller.Instance.VratiNamirnice();
                            response.Message = "Sistem je vratio namirnice!";
                            break;
                        case Operation.DodajNamirnicu:
                            Namirnica novaNamirnica = Controller.Instance.UnosNamirnice((Namirnica)r.Argument);
                            if (novaNamirnica != null)
                            {
                                response.Message = "Uspesno kreirana namirnica!";
                                response.IsSuccessfull = true;
                                Console.WriteLine("Uspesno");
                            }
                            else
                            {
                                response.Message = "Neuspesno kreiranje namirnice";
                                response.IsSuccessfull = false;
                                Console.WriteLine("Neuspesno");
                            }

                            break;
                        case Operation.IzmeniNamirnicu:
                            Controller.Instance.IzmenaNamirnice((Namirnica)r.Argument);
                            response.Message = "Sistem je izmenio namirnicu!";
                            break;
                        //case Operation.ObrisiNamirnicu:
                        //    Controller.Instance.BrisanjeNamirnice((Namirnica)r.Argument);
                        //    response.Message = "Sistem je obrisao namirnicu!";
                        //    break;
                        case Operation.VratiVrsteJela:
                            response.Result = Controller.Instance.VratiVrsteJela();
                            response.Message = "Vracene vrste jela!";
                            break;
                        case Operation.VratiJela:
                            response.Result = Controller.Instance.VratiJela();
                            response.Message = "Sistem je vratio jela!";
                            break;
                        case Operation.DodajJelo:
                            Jelo novoJelo = Controller.Instance.UnosJela((Jelo)r.Argument);
                            if (novoJelo != null)
                            {
                                response.Message = "Uspesno kreirano jelo!";
                                response.IsSuccessfull = true;
                                Console.WriteLine("Uspesno");
                            }
                            else
                            {
                                response.Message = "Neuspesno kreiranje jela";
                                response.IsSuccessfull = false;
                                Console.WriteLine("Neuspesno");
                            }

                            break;
                        case Operation.IzmeniJelo:
                            Controller.Instance.IzmenaJela((Jelo)r.Argument);
                            response.Message = "Sistem je izmenio jelo!";
                            break;
                        case Operation.DodajRecept:
                            Recept recept = Controller.Instance.UnosRecepta((Recept)r.Argument);
                            if (recept != null)
                            {
                                response.Message = "Sistem je kreirao recept!";
                                response.IsSuccessfull = true;
                            }
                            else
                            {
                                response.Message = "Sistem ne moze da kreira recept!";
                                response.IsSuccessfull = false;
                            }
                            break;
                        case Operation.VratiRecepte:
                            response.Result = Controller.Instance.VratiRecepte();
                            response.Message = "Vraceni recepti!";
                            break;

                        case Operation.VratiStavkeRecepta:
                            response.Result = Controller.Instance.VratiSR();
                            response.Message = "Vracene stavke recepta!";
                            break;
                        case Operation.IzmeniRecept:
                            Controller.Instance.IzmenaRecepta((Recept)r.Argument);
                            response.Message = "Sistem je izmenio recept!";
                            break;
                        case Operation.UcitajNamirnicu:
                            Namirnica n = Controller.Instance.UcitajNamirnicu((Namirnica)r.Argument);
                            if (n != null)
                            {
                                response.Result = n;
                                response.Message = "Sistem je učitao namirnicu!";
                                response.IsSuccessfull = true;
                            }
                            else
                            {
                                response.Message = "Sistem ne moze da ucita namirnicu!";
                                response.IsSuccessfull = false;
                            }
                            break;
                         case Operation.UcitajJelo:
                            Jelo j = Controller.Instance.UcitajJelo((Jelo)r.Argument);
                            if (j != null)
                            {
                                response.Result = j;
                                response.Message = "Sistem je učitao jelo!";
                                response.IsSuccessfull = true;
                            }
                            else
                            {
                                response.Message = "Sistem ne moze da ucita jelo!";
                                response.IsSuccessfull = false;
                            }
                            break;
                        case Operation.NadjiJelo:
                            response.Result = Controller.Instance.NadjiJelo((Jelo)r.Argument);
                            break;

                        case Operation.NadjiNamirnice:
                            response.Result = Controller.Instance.NadjiNamirnice((Namirnica)r.Argument);

                            break;

                        case Operation.UcitajRecept:
                            Recept rec = Controller.Instance.UcitajRecept((Recept)r.Argument);
                            if (rec != null)
                            {
                                response.Result = rec;
                                response.Message = "Sistem je učitao recept!";
                                response.IsSuccessfull = true;
                            }
                            else
                            {
                                response.Message = "Sistem ne moze da ucita recept!";
                                response.IsSuccessfull = false;
                            }
                            break;
                        case Operation.NadjiRecept:
                            response.Result = Controller.Instance.NadjiRecept((Recept)r.Argument);
                            break;

                        case Operation.ObrisiRecept:
                            Controller.Instance.ObrisiRecept((Recept)r.Argument);
                            response.Message = "Sistem je obrisao recept i njegove stavke!";
                            break;


                        case Operation.Odjavljivanje:

                            korisnik = (Korisnik)r.Argument;
                            Server.ulogovani.Remove(korisnik);
                            korisnik = null;

                            response.Message = "Korisnik je odjavljen sa profila";

                            break;




                        default:
                            response.Exception = new Exception("Operation doesnt exist!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    response.Exception = new Exception(ex.Message);
                    response.IsSuccessfull = false;
                }


            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            return response;
        }



    }
}
