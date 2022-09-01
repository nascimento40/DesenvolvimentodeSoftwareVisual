using System;
using System.IO;
using System.Collections.Generic;


namespace aula4
{
    class Usuario {
        static int idControl = 0;

        int id;
        string username;
        string pwdHash;

        Usuario() {
            id = 0;
            username = "";
            pwdHash = "";
        }

        public Usuario(string un, string pwd) {
            id = GenerateId();
            SetUsername(un);
            ApplyHash(pwd);
        }

        public Usuario(int i, string un, string pwd) {
            id = i;
            SetUsername(un);
            ApplyHash(pwd);
        }
        
        public string GetUsername() {
            return username;
        }
        
        public void SetUsername(string u){
            username = u;
        }

        public string GetHash() {
            return pwdHash;
        }
        
        public void SetHash(string p){
            pwdHash = p;
        }

        public void ApplyHash(string pwd) {
            //TODO aplicar hash
            pwdHash = pwd;
        }

        public int GetId() {
            return id;
        }

        static int GenerateId() {
            ++idControl;
            return idControl;
        }

        public string Serializa() {
            return id + "," + username + "," + pwdHash;
        }

        //TODO hash()
    }

    class Database {
        string filename;
        List <Usuario> usuarios;

        public Database (string f) {
            filename = f;
            string data = File.ReadAllText(filename);
            string[] linhas = data.Split("\n");
            foreach(string linha in linhas) {
                if(linha.Length > 0) {
                    string[] valores = linha.Split(",");
                    Usuario usuario = new Usuario(int.Parse(valores[0]), valores[1], valores[2]);
                    usuarios.Add(usuario);
                }
            }
        }

        public void addUser(Usuario usuario) {
            foreach (Usuario u in usuarios) {
                if(u.GetId() == usuario.GetId()) {
                    return false;
                }
            }
            usuarios.Add(usuario);
            return true;

        }

        public void save() {
            string output;
            foreach(Usuario usuario in usuarios) {
                output += usuario.Serializa() + "\n";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database("database.txt");
            database.addUser(new Usuario("Marcelo", "1234"));
            database.addUser(new Usuario("Rafael", "4321"));

            return;

            Console.WriteLine("Olá! Bem vindo ao sistema de login");
            Console.WriteLine("Digite 1 para logar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 3 para sair");
            bool sair = false;
            while(!sair){
                int opcao = 0;
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e) {
                    Console.WriteLine("valor invalido, tente novamente");
                }
                switch(opcao){
                    case 1:
                        //todo logar
                    break;
                    case 2:
                        //todo cadastrar
                    break;
                    case 3:
                        sair = true;
                    break;
                    default:
                        Console.WriteLine("opcao invalida! tente novamente");
                    break;
                }
            }
        }
    }
}
