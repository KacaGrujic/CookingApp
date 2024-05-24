using Common.Communication;
using Common.Model;
using Klijent.GuiController;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public bool connected = false;

        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 20000);
                sender = new Sender(socket);
                receiver = new Receiver(socket);
                connected = true;

            }
            catch (SystemException ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }

        public bool SocketConnected()
        {
            return connected && socket != null && socket.Connected && !(socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0);
        }



        public void Disconnect()
        {
            if (!SocketConnected())
            {

                System.Windows.Forms.MessageBox.Show("Niste konektovani na server!");

            }
        }

      

        internal Korisnik Login(string username, string password)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request request = new Request
                {
                    Operation = Operation.Login,
                    Argument = new Korisnik()
                    {
                        Username = username,
                        Password = password
                    }
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                return response.ParseResponse<Korisnik>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal void Odjavljivanje(Korisnik k)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Argument = k,
                    Operation = Operation.Odjavljivanje
                };


                sender.Send(req);

                Response response = receiver.Receive<Response>();
                System.Windows.Forms.MessageBox.Show(response.Message);


            }
            catch (IOException ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);

            }

        }
        internal List<Jelo> VratiJela()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiJela };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Jelo>>();

            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal List<Namirnica> VratiNamirnice()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiNamirnice };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Namirnica>>();

            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal List<StavkaRecepta> VratiStavkeRecepata()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiStavkeRecepta };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<StavkaRecepta>>();

            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        //public void UnosNamirnice(Namirnica namirnica)
        //{
        //    try
        //    {
        //        if (!SocketConnected()) throw new IOException("Niste konektovani na server");
        //        Request request = new Request
        //        {
        //            Operation = Operation.DodajNamirnicu,
        //            Argument = new Namirnica()
        //            {
        //                Naziv = namirnica.Naziv,
        //                Alergeni = namirnica.Alergeni
        //            }
        //        };
        //        sender.Send(request);
        //        Response response = receiver.Receive<Response>();
        //        response.ParseResponse<Namirnica>();
        //        if (!response.IsSuccessfull) throw new Exception(response.Message);

        //        if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);


        //    }
        //    catch (Exception)
        //    {

        //        Disconnect();

        //    }
        //}

        public void UnosNamirnice(Namirnica n)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request request = new Request
                {
                    Operation = Operation.DodajNamirnicu,
                    Argument = new Namirnica()
                    {
                        Naziv = n.Naziv,
                        Alergeni = n.Alergeni,
                        Kalorije = n.Kalorije
                    }
                };

                Console.WriteLine("Argument : " + request.Argument.ToString());

                sender.Send(request);
                Console.WriteLine("Poslao ");
                Response response = receiver.Receive<Response>();
                Console.WriteLine("Primio ");

                response.ParseResponse<Namirnica>();
                Console.WriteLine("Parsed ");

                if (!response.IsSuccessfull) throw new Exception(response.Message);
                Console.WriteLine(">>>>>>>>>" + response.IsSuccessfull);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);
                Console.WriteLine("Communication prosao");
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();
            }
        }

        internal void ZapamtiNamirnicu(Namirnica namirnica)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.IzmeniNamirnicu,
                    Argument = namirnica
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Namirnica>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);
                Console.WriteLine("Namirnica id " + namirnica.NamirnicaID);
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();

            }
        }

        public List<VrstaJela> VratiVrsteJela()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiVrsteJela };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<VrstaJela>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal void UnosJela(Jelo jelo)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.DodajJelo,
                    Argument = new Jelo()
                    {

                        Naziv = jelo.Naziv,
                        Kuhinja = jelo.Kuhinja,
                        VrstaJela = jelo.VrstaJela,
                    }
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Jelo>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);


            }
            catch (Exception)
            {

                Disconnect();

            }
        }

        internal void ZapamtiJelo(Jelo jelo)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.IzmeniJelo,
                    Argument = jelo
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Jelo>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);
                Console.WriteLine("Namirnica id " + jelo.JeloID);
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();

            }
        }

        internal void ZapamtiRecept(Recept r)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.DodajRecept,
                    Argument = r
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Recept>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);
                Console.WriteLine("Recept id " + r.ReceptID);
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();

            }
        }

        internal List<Recept> VratiRecepte()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiRecepte };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Recept>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal void IzmeniRecept(Recept receptZaIzmenu)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.IzmeniRecept,
                    Argument = receptZaIzmenu
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Recept>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);
                //Console.WriteLine("Namirnica id " + jelo.JeloID);
            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();

            }
        }

        internal Namirnica UcitajNamirnicu(Namirnica namirnicaZaIzmenu)
        {
            try
            {
                if (!SocketPovezan())
                {
                    throw new IOException("Niste konektovani na server");
                    return null;
                }
                Request request = new Request
                {
                    Operation = Operation.UcitajNamirnicu,
                    Argument = namirnicaZaIzmenu
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                return response.ParseResponse<Namirnica>();
            }
            catch (IOException ex)
            {
                NestoNeValja();

                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void NestoNeValja()
        {
            if (!SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server");
                //MainCoordinator.Instance.frmMain.Close();
            }
        }
        public bool SocketPovezan()
        {
            if (!connected) return false;
            if (socket == null) return false;
            if (socket.Connected == false) return false;
            bool part1 = socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
        internal Jelo UcitajJelo(Jelo jeloZaIzmenu)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UcitajJelo,
                    Argument = jeloZaIzmenu
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                return response.ParseResponse<Jelo>();
            }
            catch (IOException ex)
            {

                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }

            catch (Exception ex)
            {
                Disconnect();
                return null;
            }
        }

        internal List<Jelo> NadjiJela(Jelo j)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.NadjiJelo,
                    Argument = j

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Jelo>>();

            }
            catch (Exception ex)
            {

                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal List<Namirnica> NadjiNamirnice(Namirnica n)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.NadjiNamirnice,
                    Argument = n

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Namirnica>>();

            }
            catch (Exception ex)
            {

                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal Recept UcitajRecept(Recept rec)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UcitajRecept,
                    Argument = rec
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                return response.ParseResponse<Recept>();
            }
            catch (IOException ex)
            {

                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ex : " + ex.Message);
                return null;
            }

            catch (Exception ex)
            {
                Disconnect();
                return null;
            }
        }

        internal List<Recept> PretraziRecepte(Recept rec)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.NadjiRecept,
                    Argument = rec

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.IsSuccessfull) throw new Exception(r.Message);
                return r.ParseResponse<List<Recept>>();

            }
            catch (Exception ex)
            {

                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal void ObrisiRecept(Recept receptZaBrisanje)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.ObrisiRecept,
                    Argument = receptZaBrisanje
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Recept>();
                if (!response.IsSuccessfull) throw new Exception(response.Message);

                if (response.IsSuccessfull) System.Windows.Forms.MessageBox.Show(response.Message);

            }
            catch (Exception ecx)
            {
                Console.WriteLine("Communication exc " + ecx.Message);
                Disconnect();

            }
        }
    }
}
