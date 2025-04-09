namespace Poo.Conceitos;

public class Onibus  : Veiculo
{
    public override float Quilometragem { get; set; }

    public object Paquimetro { get; set; }
    public override bool ValidarPneu(string posicao, Pneu pneu)
    {
        if (pneus.Count() == 6)
        {
            throw new Exception("O veículo já possui 6 pneus");
        }
        return base.ValidarPneu(posicao, pneu);
    }

    protected override float CalcularPesoPorPneu()
    {
        const int QUANTIDADE_PNEUS = 6;
        return (PesoMaximo / QUANTIDADE_PNEUS) * 0.8f; 
    }
}