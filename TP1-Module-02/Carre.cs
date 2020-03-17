namespace TP1_Module_02
{
    public class Carre : Rectangle
    {
        public override int Largeur => Longueur;

        public override string ToString()
        {
            return "Carré de coté=" + this.Longueur;
        }
    }
}