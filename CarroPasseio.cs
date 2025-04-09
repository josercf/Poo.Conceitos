namespace Poo.Conceitos;

public class CarroPasseio : Veiculo
{
    public override float Quilometragem { get; set; }

    public override bool ValidarPneu(string posicao, Pneu pneu)
    {
        Console.WriteLine("Chamando validar pneu da classe CarroPasseio");

        if (pneus.Count() == 4)
        {
            throw new Exception("O veículo já possui 4 pneus");
        }
        
       return base.ValidarPneu(posicao, pneu);
    }

    protected override float CalcularPesoPorPneu()
    {
        const int QUANTIDADE_PNEUS = 4;
        return PesoMaximo / QUANTIDADE_PNEUS;
    }
}