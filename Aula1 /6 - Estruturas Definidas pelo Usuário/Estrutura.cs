namespace certificacao_csharp_roteiro{
    class Estrutura : IAulaItem
    {
        public void Executar(){
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            posicao1 = new PosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);
        }
    }

    interface IGPS{ //definindo interface 
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS{//implementando interface IGPS
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude){//metodo para setar latitude e longitude
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte(){
            return Latitude > 0;//verifica se latitude é >0, se for indica que esta no hemisferio norte
        }

        public override string ToString(){
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}