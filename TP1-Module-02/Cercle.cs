namespace TP1_Module_02
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => System.Math.PI * Rayon * Rayon;

        public override double Perimetre => 2 * System.Math.PI * Rayon;

        public override string ToString()
        {
            return "Cercle de rayon = " + this.Rayon + "\nAire = " + this.Aire + "\nPérimètre = " + this.Perimetre;
        }
    }
}