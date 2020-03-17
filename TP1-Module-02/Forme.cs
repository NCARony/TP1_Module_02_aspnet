namespace TP1_Module_02
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }
        public override string ToString()
        {
            return "Aire =" + this.Aire + "Périmètre ="+ this.Perimetre;
        }
    }
}