namespace Poo.Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Veiculo mustang = new Veiculo();
            mustang.PesoMaximo = 3_262.50f;


            //Comentamos pois não podemos gerenciar a lista de pneus diretamente
            //utilizamos encapsulamento para garantir a manipulação correta dos pneus
            //mustang.Pneus = new Dictionary<string, Pneu>();


            Medida medida = new Medida(
                largura: 225,
                perfil: 45,
                construcao: 'R',
                aro: 17,
                indiceCarga: IndiceCargaPneu.I94,
                indiceVelocidade: "W"
                );

            Pneu dd = new Pneu("Pirelli", medida); //Dianteiro Direito


            //Alteramos o tipo de string para um objeto
            //com o objetivo de manipular mais dados e realizar validações
            //dd.Medida.IndiceCarga = "94";

            //Converteos o construtor para privado, 
            //O objetivo é ter controle sobre os dados
            //dd.Medida.IndiceCarga = new IndiceCargaPneu(94, 670);

            //dd.Medida.IndiceCarga = IndiceCargaPneu.I80;
            //Alteramos a informação para o construtor.
            //Só movemos o problema de lugar
            //dd.Medida.IndiceCarga.Indice = 94;
            //dd.Medida.IndiceCarga.Carga = 670;



            //dd.Medida.IndiceVelocidade = "W";


            try
            {
                //Objeto não possui mais estafuncionalidade para a propriedade PNEUS.
                //mustang.Pneus.Add("DD", dd);
                mustang.AdicionarPneu("DD", dd);

                Pneu de = new Pneu("Goodyear", medida); //Dianteiro Esquerdo
                mustang.AdicionarPneu("DE", de);

                Pneu td = dd with { }; //Traseiro Direito
                mustang.AdicionarPneu("TD", td);

                //Pneu te = dd with { Marca = "Continental" }; //Traseiro Esquerdo
                //mustang.AdicionarPneu("TE", te);

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

            //foreach (Pneu pneu in mustang.Pneus)
            //{
            //    Console.WriteLine("Marca: " + pneu.Marca);
            //    Console.WriteLine("Medida: " + pneu.Medida.Largura + "/" + pneu.Medida.Perfil + pneu.Medida.Construcao + pneu.Medida.Aro);
            //    Console.WriteLine("Indice de Carga: " + pneu.Medida.IndiceCarga);
            //    Console.WriteLine("Indice de Velocidade: " + pneu.Medida.IndiceVelocidade);
            //    Console.WriteLine();
            //}


        }
    }
}
