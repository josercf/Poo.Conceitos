namespace Poo.Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Medida medida = new Medida(
                largura: 225,
                perfil: 45,
                construcao: 'R',
                aro: 17,
                indiceCarga: IndiceCargaPneu.I75, 
                indiceVelocidade: "W"
            );


            Moto kawazaki = new Moto();
            kawazaki.AdicionarPneu("D", new Pneu("XX", medida));
            kawazaki.AdicionarPneu("T", new Pneu("XX", medida));


            CarroPasseio mustang = new  CarroPasseio();
            mustang.PesoMaximo = 3_262.50f;
           
            Pneu dd = new Pneu("Pirelli", medida); //Dianteiro Direito

            try
            {
                //Objeto não possui mais estafuncionalidade para a propriedade PNEUS.
                //mustang.Pneus.Add("DD", dd);
                mustang.AdicionarPneu("DD", dd);

                Pneu de = new Pneu("Goodyear", medida); //Dianteiro Esquerdo
                mustang.AdicionarPneu("DD", de);

                Pneu td = dd with { }; //Traseiro Direito
                mustang.AdicionarPneu("TD", td);

                Pneu e = dd with {  }; //Traseiro Esquerdo
                mustang.AdicionarPneu("DD", e);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro:\t {ex.Message}");
            }

            foreach (KeyValuePair<string, Pneu> pneu in mustang.Pneus)
            {
                Console.WriteLine("Posição: " + pneu.Key);
                Console.WriteLine("Marca: " + pneu.Value.Marca);
                Console.WriteLine("Medida: " + pneu.Value.Medida.Largura + "/" + pneu.Value.Medida.Perfil + pneu.Value.Medida.Construcao + pneu.Value.Medida.Aro);
                Console.WriteLine("Indice de Carga: " + pneu.Value.Medida.IndiceCarga);
                Console.WriteLine("Indice de Velocidade: " + pneu.Value.Medida.IndiceVelocidade);
                Console.WriteLine();
            }
            
            Onibus busao = new Onibus();
            
            busao.AdicionarPneu("DD", new Pneu("Goodyear", medida));
            busao.AdicionarPneu("DE", new Pneu("Goodyear", medida));
            
            busao.AdicionarPneu("TDI", new Pneu("Goodyear", medida));
            busao.AdicionarPneu("TEI", new Pneu("Goodyear", medida));
            
            busao.AdicionarPneu("TDE", new Pneu("Goodyear", medida));
            busao.AdicionarPneu("TEE", new Pneu("Goodyear", medida));


            busao.Paquimetro = 50;
            
            List<Veiculo> veiculos = new List<Veiculo>();
            
            veiculos.Add(mustang);
            veiculos.Add(busao);
            veiculos.Add(kawazaki);

            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine($"KM rodado: {veiculo.Quilometragem}");
            }

        }
    }
}
