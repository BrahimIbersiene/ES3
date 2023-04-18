public static void Main(string[] args)
{
    Hotel hotel = new Hotel();

    Client client1 = new Client("Dupont", "Jean", "jean.dupont@example.com", "1234 5678 9012 3456", 101);
    hotel.ajouterClient(client1);

    Client client2 = new Client("Martin", "Sophie", "sophie.martin@example.com", "2345 6789 0123 4567", 102);
    hotel.ajouterClient(client2);

    // Accéder aux propriétés des clients en utilisant des conversions explicites
    Console.WriteLine("Le client 1 s'appelle " + ((Client)hotel.clients[0]).nom + " " + ((Client)hotel.clients[0]).prenom + " et est dans la chambre " + ((Client)hotel.clients[0]).numeroChambre);
    Console.WriteLine("Le client 2 s'appelle " + ((Client)hotel.clients[1]).nom + " " + ((Client)hotel.clients[1]).prenom + " et est dans la chambre " + ((Client)hotel.clients[1]).numeroChambre);


}