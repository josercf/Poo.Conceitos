namespace Poo.Conceitos;

public class Moto : Veiculo
{
    public override float Quilometragem { get; set; }

    protected override float CalcularPesoPorPneu()
    {
        return 300f;
    }
}