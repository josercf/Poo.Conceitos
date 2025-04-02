namespace Poo.Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Veiculo mustang = new Veiculo();
            mustang.Pneus = new List<Pneu>();


            Pneu dd = new Pneu(); //Dianteiro Direito
            dd.Marca = "Pirelli";
            dd.Medida = new Medida();
            dd.Medida.Aro = 17;
            dd.Medida.Largura = 225;
            dd.Medida.Perfil = 45;
            dd.Medida.Construcao = 'R';
            dd.Medida.IndiceCarga = "94";
            dd.Medida.IndiceVelocidade = "W";

            mustang.Pneus.Add(dd);

            Pneu de = dd; //Dianteiro Esquerdo
            mustang.Pneus.Add(de);

            Pneu td = dd; //Traseiro Direito
            mustang.Pneus.Add(td);

            Pneu te = dd; //Traseiro Esquerdo
            mustang.Pneus.Add(te);


        }
    }
}
